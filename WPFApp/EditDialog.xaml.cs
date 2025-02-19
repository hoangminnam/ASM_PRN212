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
    /// Interaction logic for EditDialog.xaml
    /// </summary>
    public partial class EditDialog : Window
    {
        private readonly IRoomInformationService roomInformationService;
        private readonly IRoomTypeService roomTypeService;
        public EditDialog()
        {
            InitializeComponent();
            roomInformationService = new RoomInformationService();
            roomTypeService = new RoomTypeService();
        }
        public void SetData(RoomInformation data)
        {
            txtRoomId.Text = data.RoomId.ToString();
            txtRoomNumber.Text = data.RoomNumber;
            txtRoomDescription.Text = data.RoomDescription;
            txtRoomMaxCapacity.Text = data.RoomMaxCapacity.ToString();
            txtRoomStatus.Text = data.RoomStatus.ToString();
            txtRoomPricePerDate.Text = data.RoomPricePerDate.ToString();
            txtRoomTypeId.Text = data.RoomTypeId.ToString();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomId.Text))
            {
                RoomInformation r = new RoomInformation();
                var count = roomInformationService.GetListRoomInformation().Count();
                if (ValidateInputs())
                {
                    r.RoomId = ++count;
                    r.RoomNumber = txtRoomNumber.Text;
                    r.RoomDescription = txtRoomDescription.Text;
                    r.RoomMaxCapacity = int.Parse(txtRoomMaxCapacity.Text);
                    r.RoomStatus = bool.Parse(txtRoomStatus.Text);
                    r.RoomPricePerDate = decimal.Parse(txtRoomPricePerDate.Text);
                    r.RoomTypeId = int.Parse(txtRoomTypeId.Text);
                    roomInformationService.AddRoomInformation(r);
                    this.DialogResult = true;
                    this.Close();
                }
            } else
            {
                int rid = int.Parse(txtRoomId.Text);
                RoomInformation r = roomInformationService.GetListRoomInformation().FirstOrDefault(r => r.RoomId == rid)!;
                if (ValidateInputs())
                {
                    r.RoomNumber = txtRoomNumber.Text;
                    r.RoomDescription = txtRoomDescription.Text;
                    r.RoomMaxCapacity = int.Parse(txtRoomMaxCapacity.Text);
                    r.RoomStatus = bool.Parse(txtRoomStatus.Text);
                    r.RoomPricePerDate = decimal.Parse(txtRoomPricePerDate.Text);
                    r.RoomTypeId = int.Parse(txtRoomTypeId.Text);
                    roomInformationService.UpdateRoomInfomation(r);
                    this.DialogResult = true;
                    this.Close();
                }
            }
            
            
            
        }

        private bool ValidateInputs()
        {
            string errorMessage = "";

            // Validate Room Number (string, 50)
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                errorMessage += "Room Number cannot be empty.\n";
            }
            else if (txtRoomNumber.Text.Length > 50)
            {
                errorMessage += "Room Number cannot exceed 50 characters.\n";
            }

            // Validate Room Description (string, 220)
            if (string.IsNullOrWhiteSpace(txtRoomDescription.Text))
            {
                errorMessage += "Room Description cannot be empty.\n";
            }
            else if (txtRoomDescription.Text.Length > 220)
            {
                errorMessage += "Room Description cannot exceed 220 characters.\n";
            }

            // Validate Room Max Capacity
            if (!Int32.TryParse(txtRoomMaxCapacity.Text, out int roomMaxCapacity))
            {
                errorMessage += "Room Max Capacity must be a valid integer number.\n";
            }
            else if (roomMaxCapacity <= 0)
            {
                errorMessage += "Room Max Capacity must be greater than zero.\n";
            }

            // Validate Room Status
            if (!bool.TryParse(txtRoomStatus.Text, out bool roomStatus))
            {
                errorMessage += "Room Status must be either true or false.\n";
            }

            // Validate Room Price Per Date
            if (!decimal.TryParse(txtRoomPricePerDate.Text, out decimal roomPricePerDate))
            {
                errorMessage += "Room Price Per Date must be a valid decimal number.\n";
            }
            else if (roomPricePerDate < 0)
            {
                errorMessage += "Room Price Per Date cannot be negative.\n";
            }
            var listRoomType = roomTypeService.GetListRoomType();
            // Validate Room Type ID
            if (!Int32.TryParse(txtRoomTypeId.Text, out int roomTypeId))
            {
                errorMessage += "Room Type ID must be a valid integer number.\n";
            }
            else if (roomTypeId <= 0)
            {
                errorMessage += "Room Type ID must be greater than zero.\n";
            } else if(!listRoomType.Any(rt => rt.RoomTypeId == roomTypeId))
            {
                errorMessage += "Room Type not exit";
            }

            // Show error message if any validations fail
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Input Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

    }
}
