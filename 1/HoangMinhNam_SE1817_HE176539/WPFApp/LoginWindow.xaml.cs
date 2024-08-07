﻿using Services;
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
using BusinessObjects;

namespace WPFApp
{
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		private readonly IAccountService iAccountService;
		public LoginWindow()
		{
			InitializeComponent();
			iAccountService = new AccountService();
		}

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
            string username = txtUser.Text;
            string password = txtPass.Password;

            bool isValidUser = iAccountService.isValidUser(username, password);
            bool isUserAuthorized = iAccountService.isUserAuthorized(username);
            if (isValidUser)
            {
                if (isUserAuthorized)
                {
                    this.Hide();
                    AdminMainWindow adminMain = new AdminMainWindow();
                    adminMain.Show();
                }
                else
                {
                    UserSession.Username = username;
                    CustomerMainWindow customerMain = new CustomerMainWindow();
                    customerMain.Show();
                    this.Hide();    
                }
            }
            else
            {
                MessageBox.Show("You are not permission !");
            }
        }

		private void btnCancel_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
