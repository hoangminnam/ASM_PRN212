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
    /// Interaction logic for BookRoomManagerWindow.xaml
    /// </summary>
    public partial class BookRoomManagerWindow : Window
    {
        private readonly IBookRoomService _bookRoomService;
        public BookRoomManagerWindow()
        {
            InitializeComponent();
            _bookRoomService = new BookRoomService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadBookRoom();
        }

        private void LoadBookRoom()
        {
            dgData.ItemsSource = null;
            var listRoomInfo = _bookRoomService.GetListBookRoom();
            if (listRoomInfo != null && listRoomInfo.Any())
            {
                dgData.ItemsSource = listRoomInfo;

            }
        }
    }
}
