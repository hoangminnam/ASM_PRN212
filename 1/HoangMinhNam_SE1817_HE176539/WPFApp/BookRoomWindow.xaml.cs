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
    /// Interaction logic for BookRoomWindow.xaml
    /// </summary>
    public partial class BookRoomWindow : Window
    {
        private readonly IRoomInformationService roomInformationService;
        public BookRoomWindow()
        {
            InitializeComponent();
            roomInformationService = new RoomInformationService();  
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadRoomInfomation();
        }

        private void LoadRoomInfomation()
        {
            dgData.ItemsSource = null;
            var listRoomInfo = roomInformationService.GetListRoomInformation();
            if (listRoomInfo != null && listRoomInfo.Any())
            {
                dgData.ItemsSource = listRoomInfo;
                
            }
        }

        private void BookSelectedRoomButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoom = dgData.SelectedItem as RoomInformation;
            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a room to book.");
                return;
            }

            if (!selectedRoom.RoomStatus)
            {
                MessageBox.Show("The selected room is not available.");
                return;
            }

            var bookingWindow = new BookingWindow(selectedRoom);
            bookingWindow.ShowDialog();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerMainWindow customerMainWindow = new CustomerMainWindow();
            customerMainWindow.Show();
            this.Close();
        }
    }
}
