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
    /// Interaction logic for EmployeesCollectionExampleWindow.xaml
    /// </summary>
    public partial class EmployeesCollectionExampleWindow : Window
    {
        public EmployeesCollectionExampleWindow()
        {
            InitializeComponent();
            this.DataContext = new EmployeeDataSource();
        }
    }
    class EmployeeDataSource
    {
        public IEnumerable<Employee> Employees { get; set; }
        public EmployeeDataSource()
        {
            Employees = new[]
            {
                new Employee("Amy", "Carter", 23),
                new Employee("Craig", "Joy", 24){ IsActive = true },
                new Employee("Mary", "Crawford", 30),
                new Employee("Jamie", "Cole", 29)
             };
        }
    }

    class Employee
    {
        private readonly int age;
        private readonly string name;
        private readonly string surname;
        public Employee(string name, string surname, int age)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
        }
        public int Age => age;
        public bool IsActive { get; set; }
        public string Name => name;
        public string Surname => surname;
        public override string ToString()
        {
            return $"{name} {surname} ({age}){(IsActive ? "Active" : "Not Active")}";
        }
    }

}
