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
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        private RoomInformation selectedRoom;
        private readonly ICustomerService customerService;
        private readonly IBookRoomService bookRoomService;
        public BookingWindow(RoomInformation room)
        {
            InitializeComponent();
            selectedRoom = room;
            customerService = new CustomerService();
            bookRoomService = new BookRoomService();    
        }

        private void BookRoomButton_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = customerService.GetCustomerByPhone(UserSession.Username);
            int rid = selectedRoom.RoomId;
            var checkInDate = CheckInDatePicker.SelectedDate ?? DateTime.Now;
            var checkOutDate = CheckOutDatePicker.SelectedDate ?? DateTime.Now;
            BookRoom bookRoom = new BookRoom();
            bookRoom.RoomId = rid;
            bookRoom.CustomerId = customer.CustomerId;
            bookRoom.DateFrom = checkInDate;
            bookRoom.DateTo = checkOutDate;
            bookRoomService.CreateBookRoom(bookRoom);
            MessageBox.Show("Booking successful!");
            this.Close();
        }
    }
}
