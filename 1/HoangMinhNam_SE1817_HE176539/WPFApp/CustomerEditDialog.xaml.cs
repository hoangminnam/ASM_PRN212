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
    /// Interaction logic for CustomerEditDialog.xaml
    /// </summary>
    public partial class CustomerEditDialog : Window
    {
        private readonly ICustomerService customerService;
        public CustomerEditDialog()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }
        public void SetData(Customer data)
        {
            txtCustomerId.Text = data.CustomerId.ToString();
            txtCustomerFullName.Text = data.CustomerFullName;
            txtTelephone.Text = data.Telephone;
            txtEmailAddress.Text = data.EmailAddress;
            chkCustomerStatus.IsChecked = data.CustomerStatus;
            txtPassword.Password = data.Password;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCustomerId.Text))
            {
                Customer customer = new Customer();
                var count = customerService.GetListCustomer().Count();
                if (ValidateInputs())
                {
                    customer.CustomerId = ++count;
                    customer.CustomerFullName = txtCustomerFullName.Text;
                    customer.Telephone = txtTelephone.Text;
                    customer.EmailAddress = txtEmailAddress.Text;
                    customer.Password = txtPassword.Password;
                    customer.CustomerStatus = chkCustomerStatus.IsChecked;
                    customerService.AddCustomer(customer);
                    this.DialogResult = true;
                    this.Close();
                }
            }
            else
            {
                int cid = int.Parse(txtCustomerId.Text);
                Customer customer = customerService.GetListCustomer().FirstOrDefault(c => c.CustomerId == cid )!;
                if (ValidateInputs())
                {
                    customer.CustomerFullName = txtCustomerFullName.Text;
                    customer.Telephone = txtTelephone.Text;
                    customer.EmailAddress = txtEmailAddress.Text;
                    customer.Password = txtPassword.Password;
                    customer.CustomerStatus = chkCustomerStatus.IsChecked;
                    customerService.UpdateCustomer(customer);
                    this.DialogResult = true;
                    this.Close();
                }
            }
        }


        private bool ValidateInputs()
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtCustomerFullName.Text))
            {
                errorMessage += "Customer Full Name cannot be empty.\n";
            }
            else if (txtCustomerFullName.Text.Length > 50)
            {
                errorMessage += "Customer Full Name cannot exceed 50 characters.\n";
            }

            if (string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                errorMessage += "Telephone cannot be empty.\n";
            }
            else if (txtTelephone.Text.Length > 12)
            {
                errorMessage += "Telephone cannot exceed 12 characters.\n";
            }

            if (string.IsNullOrWhiteSpace(txtEmailAddress.Text))
            {
                errorMessage += "Email Address cannot be empty.\n";
            }
            else if (txtEmailAddress.Text.Length > 50)
            {
                errorMessage += "Email Address cannot exceed 50 characters.\n";
            }
            else if (!IsValidEmail(txtEmailAddress.Text))
            {
                errorMessage += "Email Address is not in a valid format.\n";
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                errorMessage += "Password cannot be empty.\n";
            }
            else if (txtPassword.Password.Length > 50)
            {
                errorMessage += "Password cannot exceed 50 characters.\n";
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Input Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
