using BusinessObjects;
using DataAccessLayer;
using Services;
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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for CustomerManagerWindow.xaml
    /// </summary>
    public partial class CustomerManagerWindow : Window
    {
        private readonly ICustomerService customerService;
        public CustomerManagerWindow()
        {
            InitializeComponent();
            customerService = new CustomerService();    
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCustomerInfomation();
        }

        private void LoadCustomerInfomation()
        {
            dgData.ItemsSource = null;
            var listRoomInfo = customerService.GetListCustomer();
            if (listRoomInfo != null && listRoomInfo.Any())
            {
                dgData.ItemsSource = listRoomInfo;

            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMain = new AdminMainWindow();
            adminMain.Show();
            this.Close();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CustomerEditDialog dialog = new CustomerEditDialog();
            dialog.Title = "Create Customer";
            dialog.ShowDialog();
            LoadCustomerInfomation();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (dgData.SelectedItem != null)
            {
                var selectedItem = dgData.SelectedItem as Customer;

                CustomerEditDialog dialog = new CustomerEditDialog();
                dialog.Title = "Update Customer";
                dialog.SetData(selectedItem);
                dialog.ShowDialog();
                LoadCustomerInfomation();
            }
            else
            {
                MessageBox.Show("Please select a customer to update.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (dgData.SelectedItem != null)
            {
                var selectedItem = dgData.SelectedItem as Customer;

                var result = MessageBox.Show("Are you sure you want to delete ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    customerService.DeleteCustomer(selectedItem);
                    LoadCustomerInfomation();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
