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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для EditEmployee.xaml
    /// </summary>
    public partial class EditEmployee : Window
    {
        public string FullName => FullNameBox.Text;
        public string Position => PositionBox.Text;
        public EditEmployee(Employee selected)
        {
            InitializeComponent();
            FullNameBox.Text = selected.FullName;
            PositionBox.Text = selected.Position;
        }
        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
