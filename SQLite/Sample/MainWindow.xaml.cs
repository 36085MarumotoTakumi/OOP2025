using Sample.Data;
using SQLite;
using System;
using System.Collections.ObjectModel;
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

namespace Sample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<Person> _persons = new List<Person>();

        public MainWindow() {
            InitializeComponent();
            //_persons.Add(new Person { Id=1,Name="aaaaax",Phone="123456"});
            //ReadDatabase();
            PersonListView.ItemsSource = _persons;
        }
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Person>();
                _persons = connection.Table<Person>().ToList();
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var person = new Person() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
            };

            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Person>();
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
            var item = PersonListView.SelectedItem as Person;
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Person>();
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
            var items = PersonListView.SelectedItems as Person;
            NameTextBox.Text = items?.Name;
            PhoneTextBox.Text = items?.Phone;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var items = PersonListView.SelectedItem as Person;
            if (items is null) return;
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Person>();

                var person = new Person() {
                    Id = (PersonListView.SelectedItem as Person).Id,
                    Name = NameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                };
                connection.Update(person);
                ReadDatabase();
                PersonListView.ItemsSource = _persons;
            }
        }
    }
}