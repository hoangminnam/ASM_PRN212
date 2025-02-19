using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Room(object sender, RoutedEventArgs e)
        {
            RoomManagerWindow roomManagerWindow = new RoomManagerWindow();
            roomManagerWindow.Show();
            this.Close();
        }

        private void Button_Click_Customer(object sender, RoutedEventArgs e)
        {
            CustomerManagerWindow customerManagerWindow = new CustomerManagerWindow();
            customerManagerWindow.Show();
            this.Close();
        }
        private void Button_Click_BookRoom(object sender, RoutedEventArgs e)
        {
            BookRoomManagerWindow bookRoomManagerWindow = new BookRoomManagerWindow();
            bookRoomManagerWindow.Show();
            this.Close();
        }
    }
}