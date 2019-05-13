﻿using System;
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
using WcfService1.Models;//nz chi pralno
using WcfService1.ModelsToMap;
using WpfDentalClinicC.ServiceReference1;

namespace WpfDentalClinicC
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btn_AddNewUser_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Name.Text))
                txt_Name.Focus();
            else if (String.IsNullOrEmpty(txt_SurName.Text))
                txt_SurName.Focus();
            else if (String.IsNullOrEmpty(txt_Login.Text))
                txt_Login.Focus();
            else if (String.IsNullOrEmpty(txt_Password.Text))
                txt_Password.Focus();
            else if (String.IsNullOrEmpty(txt_Email.Text))
                txt_Email.Focus();
            else if (String.IsNullOrEmpty(txt_Phone.Text))
                txt_Phone.Focus();
            else if (String.IsNullOrEmpty(txt_Country.Text))
                txt_Country.Focus();
            else if (String.IsNullOrEmpty(txt_City.Text))
                txt_City.Focus();
            else if (String.IsNullOrEmpty(txt_Street.Text))
                txt_Street.Focus();
            else
            {
                ModelClient client = new ModelClient();
                client.Name = txt_Name.Text;
                client.SurName = txt_SurName.Text;
                client.Login = txt_Login.Text;
                client.Password = txt_Password.Text;
                client.Email = txt_Email.Text;
                client.Phone = txt_Phone.Text;
                using (Service1Client service1Client = new Service1Client())
                {
                    bool Chak = service1Client.ChakLoginAddNewClient(txt_Login.Text);
                    if (Chak == false)
                    {
                        service1Client.AddClient(client, txt_City.Text, txt_Street.Text, txt_Country.Text);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Даний логін уже занятий", "Увага");
                    }
                }
            }
        }
    }
}
