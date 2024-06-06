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
    /// Interaction logic for BindingExampleWindow.xaml
    /// </summary>
    public partial class BindingExampleWindow : Window
    {
        public BindingExampleWindow()
        {
            InitializeComponent();

            Binding binding = new Binding();
            binding.ElementName = "myTextBox";
            binding.Path = new PropertyPath("Text");

            myTextBlock.SetBinding(TextBlock.TextProperty, binding);

            BindingOperations.ClearBinding(myTextBlock, TextBlock.TextProperty);
            BindingOperations.ClearAllBindings(myTextBlock);
        }
    }
}
