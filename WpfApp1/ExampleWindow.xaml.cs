using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ExampleWindows.xaml
    /// </summary>
    public partial class ExampleWindow : Window
    {
        private readonly DispatcherTimer timer;

        public ExampleWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(300)
            };
            timer.Tick += Timer_Tick;
            this.Loaded += Window_Loaded;
            DataContext = new DataSource();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!timer.IsEnabled)
            {
                timer.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            ++((DataSource)DataContext).Value;
           //UpdateTextBlock();
        }
        private void UpdateTextBlock()
        {
            textBlock.Text = ((DataSource)DataContext).Value.ToString();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateTextBlock();
        }

    }
    class DataSource : ViewModelBase
    {
        private int _value = 1;
        public int Value
        {
            get => _value;
            set
            {
                if (!this._value.Equals(value))
                {
                    SetProperty(ref _value, value, "Value");
                }
            }
        }
    }

}
