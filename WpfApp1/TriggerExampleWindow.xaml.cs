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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for TriggerExampleWindow.xaml
    /// </summary>
    public partial class TriggerExampleWindow : Window
    {
        public TriggerExampleWindow()
        {
            InitializeComponent();
            this.DataContext = new TriggerUser();
        }
    }
    class TriggerUser : ViewModelBase
    {
        private string name;
        private string surName;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value, "Name");
        }
        public string SurName
        {
            get => surName;
            set => SetProperty(ref surName, value, "SurName");
        }
    }

}
