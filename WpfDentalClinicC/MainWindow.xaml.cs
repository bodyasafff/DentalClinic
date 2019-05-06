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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDentalClinicC.ServiceReference1;

namespace WpfDentalClinicC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<WcfService1.Models.Client> clients = new List<WcfService1.Models.Client>();
        public MainWindow()
        {
            InitializeComponent();
            using (Service1Client service1Client = new Service1Client())
            {
                //int i = service1Client.CountClient();
  //              WcfService1.Models.Client[] c =  service1Client.GetAllClients();
            }
        }

        private void btn_SignUpClick(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }
    }
}
