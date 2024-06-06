using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Phone()
            {
                Title = "Samsung C65",
                Company = "Samsung",
                Price = 399
            };

        }
        private void OpenForm_Click(object sender, RoutedEventArgs e)
        {
            var exampleWindow = new EmployeesCollectionExampleWindow();
            exampleWindow.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Phone phone = (Phone)this.DataContext;
            phone.Company = "LG"; // Меняем с Google на LG
        }

    }
    //class Phone : INotifyPropertyChanged
    //{
    //    //public string Title { get; set; }
    //    //public string Company { get; set; }
    //    //public int Price { get; set; }

    //    private string title;
    //    private string company;
    //    private int price;

    //    public string Title
    //    {
    //        get { return title; }
    //        set
    //        {
    //            title = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //    public string Company
    //    {
    //        get { return company; }
    //        set
    //        {
    //            company = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //    public int Price
    //    {
    //        get { return price; }
    //        set
    //        {
    //            price = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    public event PropertyChangedEventHandler? PropertyChanged;

    //    public void OnPropertyChanged([CallerMemberName] string prop = "")
    //    {
    //        if (PropertyChanged != null)
    //            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    //    }
    //}

    class Phone : ViewModelBase
    {
        private string title;
        private string company;
        private int price;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
        public string Company
        {
            get => company;
            set => SetProperty(ref company, value);
        }
        public int Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }
    }

}