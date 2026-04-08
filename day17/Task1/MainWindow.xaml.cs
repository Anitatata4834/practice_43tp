using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeViewModel _vm;
        public static NotificationViewModel GlobalNotifications = new NotificationViewModel();

        public MainWindow(string username)
        {
            InitializeComponent();
            this.KeyDown += MainWindow_KeyDown;


            _vm = new EmployeeViewModel(username);
            DataContext = _vm;

            EmployeeList.ItemsSource = _vm.Employees;

            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadingBar.Visibility = Visibility.Visible;
            EmployeeList.Visibility = Visibility.Collapsed;

            await _vm.LoadEmployeesAsync();

            LoadingBar.Visibility = Visibility.Collapsed;
            EmployeeList.Visibility = Visibility.Visible;
        }


        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.N)
                AddEmployee_Click(null, null);

            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.E)
                EditEmployee_Click(null, null);

            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.D)
                DeleteEmployee_Click(null, null);
        }

        private void FilterChanged(object sender, RoutedEventArgs e)
        {
            if (_vm == null)
                return;
            RadioButton radio = sender as RadioButton;
            string filter = radio.Content.ToString();

            EmployeeList.ItemsSource = _vm.Filter(filter);
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            if (ae.ShowDialog() == true)
            {
                _vm.AddEmployee(ae.FullName, ae.Position);

            }
        }

        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeModel selected = EmployeeList.SelectedItem as EmployeeModel;
            if (selected == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            EditEmployee ee = new EditEmployee(selected);
            if (ee.ShowDialog() == true)
            {
                selected.FullName = ee.FullName;
                selected.Position = ee.Position;
                EmployeeList.Items.Refresh();
                _vm.EditEmployee(selected, selected.FullName, selected.Position);
            }
        }

        private void DeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeModel selected = EmployeeList.SelectedItem as EmployeeModel;
            if (selected == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }
            MessageBoxResult result = MessageBox.Show(
                $"Удалить сотрудника:\n{selected.FullName} ({selected.Position})?",
                "Подтверждение удаления",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
                _vm.DeleteEmployee(selected);
        }
        private void OpenChat_Click(object sender, RoutedEventArgs e)
        {
            new ChatView().Show();
        }

        private void OpenNotifications_Click(object sender, RoutedEventArgs e)
        {
            new NotificationView().Show();

        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchBox.Text == "Поиск сотрудника")
                return;

            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                SearchPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                SearchPlaceholder.Visibility = Visibility.Collapsed;
            }

            RunSearchAnimation(SearchBox.Text);
        }


        private async void RunSearchAnimation(string query)
        {
            if (_vm == null || _vm.Employees == null)
                return;

            string lower = query.ToLower();

            IEnumerable<EmployeeModel> currentSource;

            if (EmployeeList.ItemsSource != null)
                currentSource = EmployeeList.ItemsSource.Cast<EmployeeModel>();
            else
                currentSource = _vm.Employees;
            List<EmployeeModel> results = new List<EmployeeModel>();

            foreach (EmployeeModel emp in currentSource)
            {
                if (emp.FullName.ToLower().Contains(lower))
                {
                    results.Add(emp);
                }
            }

            EmployeeList.ItemsSource = null;
            EmployeeList.Items.Clear();

            foreach (EmployeeModel emp in results)
            {
                EmployeeList.Items.Add(emp);
                await Task.Delay(120);
            }
        }
        private void EmployeeItem_Click(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement fe && fe.DataContext is EmployeeModel emp)
            {
                emp.IsOnline = !emp.IsOnline;
            }
        }

        public static T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is T typedChild)
                    return typedChild;

                var result = FindVisualChild<T>(child);
                if (result != null)
                    return result;
            }

            return null;
        }

    }
}