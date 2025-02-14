using BusinessObjects;
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
    /// Interaction logic for CustomerMainWindow.xaml
    /// </summary>
    public partial class CustomerMainWindow : Window
    {
        private readonly ICustomerService _customerService;
        public CustomerMainWindow()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void Button_Click_Profile(object sender, RoutedEventArgs e)
        {
            string user = UserSession.Username;
            Customer customer = _customerService.GetCustomerByPhone(user);

            CustomerEditDialog dialog = new CustomerEditDialog();
            dialog.Title = "Update Customer";
            dialog.SetData(customer);
            dialog.ShowDialog();
        }

        private void Button_Click_BookingRoom(object sender, RoutedEventArgs e)
        {
            BookRoomWindow window = new BookRoomWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_BookingHistory(object sender, RoutedEventArgs e)
        {
            BookRoomHistoryWindow bookRoomHistoryWindow = new BookRoomHistoryWindow();
            bookRoomHistoryWindow.Show();
            this.Close();
        }
    }
}
