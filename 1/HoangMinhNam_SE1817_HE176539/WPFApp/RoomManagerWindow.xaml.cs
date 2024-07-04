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
    /// Interaction logic for RoomManagerWindow.xaml
    /// </summary>
    public partial class RoomManagerWindow : Window
    {
        private readonly IRoomInformationService roomInformationService;
        public RoomManagerWindow()
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
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            EditDialog dialog = new EditDialog();
            dialog.Title = "Create Item";
            dialog.ShowDialog();
            LoadRoomInfomation();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgData.SelectedItem != null)
            {
                var selectedItem = dgData.SelectedItem as RoomInformation; 

                EditDialog dialog = new EditDialog();
                dialog.Title = "Update Item";
                dialog.SetData(selectedItem); 
                dialog.ShowDialog();
                LoadRoomInfomation();
            }
            else
            {
                MessageBox.Show("Please select an item to update.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMain = new AdminMainWindow();
            adminMain.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgData.SelectedItem != null)
            {
                var selectedItem = dgData.SelectedItem as RoomInformation;

                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    roomInformationService.RemoveRoomInformation(selectedItem);
                    LoadRoomInfomation();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
