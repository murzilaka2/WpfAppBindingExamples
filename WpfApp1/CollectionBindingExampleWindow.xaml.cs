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
    /// Interaction logic for CollectionBindingExampleWindow.xaml
    /// </summary>
    public partial class CollectionBindingExampleWindow : Window
    {
        private CollectionDataSource dataSource;

        public CollectionBindingExampleWindow()
        {
            InitializeComponent();
            dataSource = new CollectionDataSource();
            this.DataContext = dataSource;
        }
        private void NoNotificationButton_Click(object sender, RoutedEventArgs e)
        {
            dataSource.NonNotifiableCollection.Add(new Random().Next(10, 100));
        }

        private void NotificationButton_Click(object sender, RoutedEventArgs e)
        {
            dataSource.NotifiableCollection.Add(new Random().Next(10, 100));
        }

    }

    public class CollectionDataSource
    {
        private readonly ICollection<int> nonNotifiableCollection = new List<int> { 1, 2, 3 };
        private readonly ICollection<int> notifiableCollection = new ObservableCollection<int> { 1, 2, 3 };
        public ICollection<int> NonNotifiableCollection => nonNotifiableCollection;
        public ICollection<int> NotifiableCollection => notifiableCollection;
        public void AddValueToNonNotifiableCollection()
        {
            nonNotifiableCollection.Add(nonNotifiableCollection.Count + 1);
        }
        public void AddValueToNotifiableCollection()
        {
            notifiableCollection.Add(notifiableCollection.Count + 1);
        }
    }

}
