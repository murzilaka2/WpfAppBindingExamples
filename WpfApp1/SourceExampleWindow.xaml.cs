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
    /// Interaction logic for SourceExampleWindow.xaml
    /// </summary>
    public partial class SourceExampleWindow : Window
    {
        public SourceExampleWindow()
        {
            InitializeComponent();
        }
    }
    class SourcePhone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }

}
