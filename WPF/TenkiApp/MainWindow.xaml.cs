using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;

namespace TenkiApp {
    public partial class MainWindow : Window {

        // ▼▼▼ 修正1: HttpClientをstaticで1つだけ作成し、使い回す ▼▼▼
        private static readonly HttpClient _httpClient = new HttpClient();

        private System.Threading.CancellationTokenSource _searchCts;
        private bool _isProgrammaticUpdate = false; // プログラムによるテキスト変更かどうかのフラグ

        // 静的コンストラクタでヘッダーを一度だけ設定
        static MainWindow() {
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "TenkiApp/1.0");
        }

        public MainWindow() {
            InitializeComponent();
            this.MouseLeftButtonDown += (s, e) => { if (e.ButtonState == MouseButtonState.Pressed) this.DragMove(); };

            Loaded += async (s, e) => await LoadWeatherDataFromIp();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) => this.Close();

        private void ScrollHourly_PreviewMouseWheel(object sender, MouseWheelEventArgs e) {
            var scrollViewer = sender as ScrollViewer;
            if (scrollViewer == null) return;
            if (e.Delta > 0) scrollViewer.LineLeft();
            else scrollViewer.LineRight();
            e.Handled = true;
        }

        // --- 1. IPアドレスから現在地を取得 ---
        private async Task LoadWeatherDataFromIp() {
            try {
                TxtCityLabel.Text = "Locating...";

                // ▼▼▼ 修正: 共通の _httpClient を使用 ▼▼▼
                string json = await _httpClient.GetStringAsync("http://ip-api.com/json/");
                var ipData = JsonSerializer.Deserialize<IpApiResponse>(json);

                if (ipData != null && ipData.Status == "success") {
                    // 入力欄更新時に検索が走らないようにフラグを立てる
                    _isProgrammaticUpdate = true;
                    TxtLocationInput.Text = ipData.City;
                    _isProgrammaticUpdate = false;

                    TxtCityLabel.Text = ipData.City;
                    await LoadWeatherData(ipData.Lat, ipData.Lon);
                } else {
                    TxtCityLabel.Text = "Tokyo";
                    await LoadWeatherData(35.6895, 139.6917);
                }
            }
            catch {
                TxtCityLabel.Text = "Tokyo";
                await LoadWeatherData(35.6895, 139.6917);
            }
        }

        // --- 2. テキスト入力で地域検索 (Geocoding API) ---
        private async void TxtLocationInput_TextChanged(object sender, TextChangedEventArgs e) {
            // ▼▼▼ 追加: コードからの変更なら検索しない ▼▼▼
            if (_isProgrammaticUpdate) return;

            var text = TxtLocationInput.Text.Trim();
            if (string.IsNullOrEmpty(text) || text.Length < 2) {
                PopupSuggestions.IsOpen = false;
                PbSearchLoading.Visibility = Visibility.Collapsed;
                return;
            }

            _searchCts?.Cancel();
            _searchCts = new System.Threading.CancellationTokenSource();
            var token = _searchCts.Token;

            try {
                PbSearchLoading.Visibility = Visibility.Visible;
                await Task.Delay(500, token);
                if (token.IsCancellationRequested) return;

                string url = $"https://geocoding-api.open-meteo.com/v1/search?name={text}&count=5&language=ja&format=json";

                // ▼▼▼ 修正: 共通の _httpClient を使用 ▼▼▼
                string json = await _httpClient.GetStringAsync(url, token);
                var searchResult = JsonSerializer.Deserialize<GeoSearchResponse>(json);

                if (searchResult?.Results != null && searchResult.Results.Count > 0) {
                    ListSuggestions.ItemsSource = searchResult.Results;
                    PopupSuggestions.IsOpen = true;
                } else {
                    PopupSuggestions.IsOpen = false;
                }
            }
            catch (TaskCanceledException) {
                // 無視
            }
            catch {
                PopupSuggestions.IsOpen = false;
            }
            finally {
                if (!token.IsCancellationRequested) {
                    PbSearchLoading.Visibility = Visibility.Collapsed;
                }
            }
        }

        // --- 3. 候補選択時の処理 ---
        private async void ListSuggestions_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (ListSuggestions.SelectedItem is GeoLocationItem selectedItem) {
                PopupSuggestions.IsOpen = false;

                // ▼▼▼ 追加: 検索を走らせずにテキストを更新 ▼▼▼
                _isProgrammaticUpdate = true;
                TxtLocationInput.Text = selectedItem.Name;
                _isProgrammaticUpdate = false;

                TxtCityLabel.Text = selectedItem.Name;
                TxtCurrentTemp.Text = "--°";
                TxtCurrentWeatherDescription.Text = "Loading...";
                TxtCurrentWeatherIcon.Text = "";

                await LoadWeatherData(selectedItem.Latitude, selectedItem.Longitude);

                ListSuggestions.SelectionChanged -= ListSuggestions_SelectionChanged;
                ListSuggestions.SelectedItem = null;
                ListSuggestions.SelectionChanged += ListSuggestions_SelectionChanged;
            }
        }

        // --- 天気データ取得 (共通) ---
        private async Task LoadWeatherData(double lat, double lon) {
            string apiUrl = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&hourly=temperature_2m,weather_code,wind_speed_10m,wind_direction_10m,uv_index&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max&timezone=auto";

            try {
                // ▼▼▼ 修正: 共通の _httpClient を使用 ▼▼▼
                string json = await _httpClient.GetStringAsync(apiUrl);
                var weatherData = JsonSerializer.Deserialize<OpenMeteoResponse>(json);

                if (weatherData != null) {
                    UpdateUI(weatherData);
                }
            }
            catch (Exception ex) {
                TxtCurrentWeatherDescription.Text = "Error";
                MessageBox.Show($"データの取得に失敗しました: {ex.Message}");
            }
        }

        private void UpdateUI(OpenMeteoResponse data) {
            var now = DateTime.Now;

            // Hourly
            var hourlyList = new List<WeatherDisplayItem>();
            if (data.Hourly != null) {
                for (int i = 0; i < data.Hourly.Time.Count; i++) {
                    if (DateTime.TryParse(data.Hourly.Time[i], out DateTime time)) {
                        if (time >= now.AddHours(-1) && time < now.AddHours(24)) {
                            int code = data.Hourly.WeatherCode[i];
                            var (weatherName, icon, colorHex) = ParseWmoCode(code);

                            double speed = data.Hourly.WindSpeed10m.Count > i ? data.Hourly.WindSpeed10m[i] : 0;
                            int dir = data.Hourly.WindDirection10m.Count > i ? data.Hourly.WindDirection10m[i] : 0;
                            double uv = data.Hourly.UvIndex.Count > i ? data.Hourly.UvIndex[i] : 0;
                            string dirStr = GetWindDirectionString(dir);

                            hourlyList.Add(new WeatherDisplayItem {
                                TimeLabel = time.ToString("HH:mm"),
                                Temperature = data.Hourly.Temperature2m[i].ToString("0"),
                                WeatherDescription = weatherName,
                                WeatherIcon = icon,
                                IconColor = colorHex,
                                WindInfo = $"{speed:0}km/h {dirStr}",
                                UvInfo = $"UV: {uv:0.0}"
                            });
                        }
                    }
                }
            }

            var currentItem = hourlyList.FirstOrDefault(x => DateTime.Parse(x.TimeLabel).Hour == now.Hour) ?? hourlyList.FirstOrDefault();
            if (currentItem != null) {
                TxtCurrentTemp.Text = $"{currentItem.Temperature}°C";
                TxtCurrentWeatherDescription.Text = currentItem.WeatherDescription;
                TxtCurrentWeatherIcon.Text = currentItem.WeatherIcon;
                try {
                    TxtCurrentWeatherIcon.Foreground = (Brush)new BrushConverter().ConvertFromString(currentItem.IconColor);
                }
                catch { }
            }

            ListForecastHorizontal.ItemsSource = hourlyList;
            ScrollHourly.ScrollToHorizontalOffset(0);

            // Daily
            var dailyList = new List<DailyWeatherDisplayItem>();
            if (data.Daily != null) {
                for (int i = 0; i < data.Daily.Time.Count; i++) {
                    if (DateTime.TryParse(data.Daily.Time[i], out DateTime date)) {
                        int code = data.Daily.WeatherCode[i];
                        var (_, icon, colorHex) = ParseWmoCode(code);
                        double max = data.Daily.TempMax[i];
                        double min = data.Daily.TempMin[i];
                        int pop = data.Daily.PrecipitationProb[i];
                        string popText = pop > 0 ? $"{pop}%" : "";

                        dailyList.Add(new DailyWeatherDisplayItem {
                            DayLabel = date.ToString("ddd"),
                            WeatherIcon = icon,
                            IconColor = colorHex,
                            MaxTemp = $"{max:0}°",
                            MinTemp = $"{min:0}°",
                            PopLabel = popText
                        });
                    }
                }
            }
            ListForecastSidebar.ItemsSource = dailyList;
        }

        private string GetWindDirectionString(int degrees) {
            string[] directions = { "北", "北東", "東", "南東", "南", "南西", "西", "北西", "北" };
            int index = (int)Math.Round(((double)degrees % 360) / 45);
            return directions[index];
        }

        private (string name, string icon, string color) ParseWmoCode(int code) {
            return code switch {
                0 => ("快晴", "☀️", "#FFB300"),
                1 => ("晴れ", "🌤️", "#FFB300"),
                2 => ("一部曇り", "⛅", "#CFD8DC"),
                3 => ("曇り", "☁️", "#90A4AE"),
                45 or 48 => ("霧", "🌫️", "#78909C"),
                51 or 53 or 55 => ("霧雨", "🌧️", "#4FC3F7"),
                61 or 63 or 65 => ("雨", "☔", "#29B6F6"),
                80 or 81 or 82 => ("にわか雨", "🌦️", "#29B6F6"),
                85 or 86 => ("雪", "☃️", "#FFFFFF"),
                71 or 73 or 75 => ("雪", "☃️", "#FFFFFF"),
                95 or 96 or 99 => ("雷雨", "⚡", "#FFD600"),
                _ => ("不明", "❓", "#FFFFFF")
            };
        }
    }

    // --- データモデル (変更なし) ---
    public class WeatherDisplayItem {
        public string TimeLabel { get; set; }
        public string Temperature { get; set; }
        public string WeatherDescription { get; set; }
        public string WeatherIcon { get; set; }
        public string IconColor { get; set; }
        public string WindInfo { get; set; }
        public string UvInfo { get; set; }
    }
    public class DailyWeatherDisplayItem {
        public string DayLabel { get; set; }
        public string WeatherIcon { get; set; }
        public string IconColor { get; set; }
        public string MaxTemp { get; set; }
        public string MinTemp { get; set; }
        public string PopLabel { get; set; }
    }
    public class OpenMeteoResponse {
        [JsonPropertyName("hourly")] public HourlyData Hourly { get; set; }
        [JsonPropertyName("daily")] public DailyData Daily { get; set; }
    }
    public class HourlyData {
        [JsonPropertyName("time")] public List<string> Time { get; set; }
        [JsonPropertyName("temperature_2m")] public List<double> Temperature2m { get; set; }
        [JsonPropertyName("weather_code")] public List<int> WeatherCode { get; set; }
        [JsonPropertyName("wind_speed_10m")] public List<double> WindSpeed10m { get; set; }
        [JsonPropertyName("wind_direction_10m")] public List<int> WindDirection10m { get; set; }
        [JsonPropertyName("uv_index")] public List<double> UvIndex { get; set; }
    }
    public class DailyData {
        [JsonPropertyName("time")] public List<string> Time { get; set; }
        [JsonPropertyName("weather_code")] public List<int> WeatherCode { get; set; }
        [JsonPropertyName("temperature_2m_max")] public List<double> TempMax { get; set; }
        [JsonPropertyName("temperature_2m_min")] public List<double> TempMin { get; set; }
        [JsonPropertyName("precipitation_probability_max")] public List<int> PrecipitationProb { get; set; }
    }
    public class GeoSearchResponse {
        [JsonPropertyName("results")] public List<GeoLocationItem> Results { get; set; }
    }
    public class GeoLocationItem {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("latitude")] public double Latitude { get; set; }
        [JsonPropertyName("longitude")] public double Longitude { get; set; }
        [JsonPropertyName("country")] public string Country { get; set; }
        [JsonPropertyName("admin1")] public string Admin1 { get; set; }
    }
    public class IpApiResponse {
        [JsonPropertyName("status")] public string Status { get; set; }
        [JsonPropertyName("city")] public string City { get; set; }
        [JsonPropertyName("lat")] public double Lat { get; set; }
        [JsonPropertyName("lon")] public double Lon { get; set; }
    }
}