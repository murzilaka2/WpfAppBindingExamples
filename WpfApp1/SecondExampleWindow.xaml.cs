using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for SecondExampleWindow.xaml
    /// </summary>
    public partial class SecondExampleWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public SecondExampleWindow()
        {
            InitializeComponent();
            userListView.ItemsSource = users;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Name = nameTextBox.Text,
                Age = int.Parse(ageTextBox.Text)
            };
            users.Add(user);
        }

    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
