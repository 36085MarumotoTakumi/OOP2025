using Microsoft.Web.WebView2.Core;
using System.Net.Sockets;
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

namespace WebBrowser {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            InitializeAsync();
        }
        private async void InitializeAsync() {
            await WebView.EnsureCoreWebView2Async();

            WebView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            WebView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
        }

        private void CoreWebView2_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e) {
           LoadingBar.Visibility = Visibility.Collapsed;
            LoadingBar.IsIndeterminate = true;        
        }

        private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e) {
           LoadingBar.Visibility = Visibility.Visible;
            LoadingBar.IsIndeterminate = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            WebView.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {

            WebView.GoForward();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e) {
            var url =AddressBar.Text.Trim();
            if (string.IsNullOrWhiteSpace(url)) return; 
            WebView.Source = new Uri(url);
        }
    }
}