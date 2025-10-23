using CustomerApp.Data;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomerApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<Customer> _persons = new List<Customer>();

        public MainWindow() {

            InitializeComponent();

            PersonListView.ItemsSource = _persons;
        }
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                _persons = connection.Table<Customer>().ToList();
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var person = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = _selectedPictureBytes
            };

            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                connection.Insert(person);
            }
            ReadDatabase();
            PersonListView.ItemsSource = _persons;
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e) {
            ReadDatabase();
            PersonListView.ItemsSource = _persons;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = PersonListView.SelectedItem as Customer;
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                if (item != null) {
                    connection.Delete(item);
                } else {
                    MessageBox.Show("行を選択してください", "", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                ReadDatabase();
                PersonListView.ItemsSource = _persons;
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _persons.Where(x => x.Name.Contains(SearchTextBox.Text));
            PersonListView.ItemsSource = filterList;

        }
        private void PersonListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var items = PersonListView.SelectedItems as Customer;
            NameTextBox.Text = items?.Name;
            PhoneTextBox.Text = items?.Phone;
            AddressTextBox.Text = items?.Address;
            //PictureBox.Source = items?.Picture;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var items = PersonListView.SelectedItem as Customer;
            if (items is null) return;
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();

                var person = new Customer() {
                    Id = (PersonListView.SelectedItem as Customer).Id,
                    Name = NameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Address = AddressTextBox.Text,

                };
                connection.Update(person);
                ReadDatabase();
                PersonListView.ItemsSource = _persons;
            }
        }

        private byte[] _selectedPictureBytes;

        private void PictureButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true) {
                PictureBox.Source = new BitmapImage(new Uri(ofd.FileName));
                _selectedPictureBytes = File.ReadAllBytes(ofd.FileName);
            }
        }

    }
}