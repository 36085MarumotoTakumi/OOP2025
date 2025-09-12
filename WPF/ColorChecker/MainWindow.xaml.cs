using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor currentColor;

        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList();
        }
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            var myColor = new MyColor() { Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value) };
            colorArea.Background = new SolidColorBrush(myColor.Color);
        }

        private void stockButton_Button_Click(object sender, RoutedEventArgs e) {
            if (colorArea.Background is SolidColorBrush brush) {
                Color color = brush.Color;
                var predefinedColors = GetColorList();
                var matchedColor = predefinedColors.FirstOrDefault(c => c.Color.Equals(color));
                if (matchedColor == null) {
                    currentColor = new MyColor() {
                        Color = color,
                        Name = $"R: {color.R} G: {color.G} B: {color.B}"
                    };
                } else {
                    currentColor = new MyColor() {
                        Color = color,
                        Name = matchedColor.Name
                    };
                }
            }
            if (!stockList.Items.Cast<MyColor>().Any(c => c.Color == currentColor.Color)) {
                stockList.Items.Insert(0, currentColor);
            } else {
                MessageBox.Show("既に登録済みです", "", MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }


        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var comboSelectMyColor = (MyColor)((ComboBox)sender).SelectedItem;
            setSliderValue(comboSelectMyColor.Color);

        }

        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var StockSelectMyColor = (MyColor)stockList.SelectedItem;
            setSliderValue(StockSelectMyColor.Color);
        }
    }
}
