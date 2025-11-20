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

namespace TenkiApp {
    public partial class MainWindow : Window {
        private readonly List<CityLocation> _locations = new List<CityLocation>
        {
            new CityLocation("Tokyo", 35.6895, 139.6917),
            new CityLocation("Osaka", 34.6937, 135.5023),
            new CityLocation("Nagoya", 35.1815, 136.9066),
            new CityLocation("Sapporo", 43.0667, 141.3500),
            new CityLocation("Fukuoka", 33.5904, 130.4017),
            new CityLocation("Naha", 26.2124, 127.6809),
            new CityLocation("New York", 40.7128, -74.0060),
            new CityLocation("London", 51.5074, -0.1278)
        };

        public MainWindow() {
            InitializeComponent();

            this.MouseLeftButtonDown += (s, e) => { if (e.ButtonState == MouseButtonState.Pressed) this.DragMove(); };

            CboLocations.ItemsSource = _locations;
            CboLocations.SelectedIndex = 0;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) => this.Close();

        private async void CboLocations_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (CboLocations.SelectedItem is CityLocation selectedCity) {
                TxtCityLabel.Text = selectedCity.Name;
                await LoadWeatherData(selectedCity);
            }
        }

        private async Task LoadWeatherData(CityLocation city) {
            string apiUrl = $"https://api.open-meteo.com/v1/forecast?latitude={city.Lat}&longitude={city.Lon}&hourly=temperature_2m,weather_code&timezone=auto";

            try {
                using (HttpClient client = new HttpClient()) {
                    client.DefaultRequestHeaders.Add("User-Agent", "TenkiApp/1.0");

                    string json = await client.GetStringAsync(apiUrl);
                    var weatherData = JsonSerializer.Deserialize<OpenMeteoResponse>(json);

                    if (weatherData?.Hourly != null) {
                        UpdateUI(weatherData);
                    }
                }
            }
            catch (Exception ex) {
                TxtCurrentWeather.Text = "Error";
                MessageBox.Show($"データの取得に失敗しました: {ex.Message}");
            }
        }

        private void UpdateUI(OpenMeteoResponse data) {
            var displayList = new List<WeatherDisplayItem>();
            var now = DateTime.Now;

            for (int i = 0; i < data.Hourly.Time.Count; i++) {
                if (DateTime.TryParse(data.Hourly.Time[i], out DateTime time)) {
                    if (time >= now.AddHours(-1) && time < now.AddHours(24)) {
                        int code = data.Hourly.WeatherCode[i];
                        var (weatherName, icon) = ParseWmoCode(code);

                        displayList.Add(new WeatherDisplayItem {
                            TimeLabel = time.ToString("HH:mm"),
                            Temperature = data.Hourly.Temperature2m[i].ToString("0.0"),
                            WeatherDescription = $"{icon} {weatherName}",
                        });
                    }
                }
            }

            var currentItem = displayList.FirstOrDefault();
            if (currentItem != null) {
                TxtCurrentTemp.Text = $"{currentItem.Temperature}°C";
                TxtCurrentWeather.Text = currentItem.WeatherDescription;
            }

            ListForecast.ItemsSource = displayList;
        }

        private (string name, string icon) ParseWmoCode(int code) {
            return code switch {
                0 => ("快晴", "☀️"),
                1 => ("晴れ", "🌤️"),
                2 => ("一部曇り", "⛅"),
                3 => ("曇り", "☁️"),
                45 or 48 => ("霧", "🌫️"),
                51 or 53 or 55 => ("霧雨", "🌧️"),
                61 or 63 or 65 => ("雨", "☔"),
                71 or 73 or 75 => ("雪", "☃️"),
                95 or 96 or 99 => ("雷雨", "⚡"),
                _ => ("不明", "❓")
            };
        }
    }

    // --- データモデル ---

    public class CityLocation {
        public string Name { get; }
        public double Lat { get; }
        public double Lon { get; }

        public CityLocation(string name, double lat, double lon) {
            Name = name;
            Lat = lat;
            Lon = lon;
        }
    }

    public class WeatherDisplayItem {
        public string TimeLabel { get; set; }
        public string Temperature { get; set; }
        public string WeatherDescription { get; set; }
    }

    public class OpenMeteoResponse {
        [JsonPropertyName("hourly")]
        public HourlyData Hourly { get; set; }
    }

    public class HourlyData {
        [JsonPropertyName("time")]
        public List<string> Time { get; set; }

        [JsonPropertyName("temperature_2m")]
        public List<double> Temperature2m { get; set; }

        [JsonPropertyName("weather_code")]
        public List<int> WeatherCode { get; set; }
    }
}