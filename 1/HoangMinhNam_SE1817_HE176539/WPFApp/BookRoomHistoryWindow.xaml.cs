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
    /// Interaction logic for BookRoomHistoryWindow.xaml
    /// </summary>
    public partial class BookRoomHistoryWindow : Window
    {
        private readonly IBookRoomService _bookRoomService;
        private readonly ICustomerService _customerService;
        public BookRoomHistoryWindow()
        {
            InitializeComponent();
            _bookRoomService = new BookRoomService();  
            _customerService = new CustomerService();   
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadBookRoom();
        }

        private void LoadBookRoom()
        {
            dgData.ItemsSource = null;
            Customer customer = _customerService.GetCustomerByPhone(UserSession.Username);
            var listRoomInfo = _bookRoomService.GetListBookRoom().Where(c => c.CustomerId == customer.CustomerId);
            if (listRoomInfo != null && listRoomInfo.Any())
            {
                dgData.ItemsSource = listRoomInfo;

            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CustomerMainWindow customerMainWindow = new CustomerMainWindow();
            customerMainWindow.Show();
            this.Close();
        }
    }
}
