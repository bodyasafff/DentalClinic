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
using WcfService1.Models;

namespace WpfDentalClinicC
{
    /// <summary>
    /// Interaction logic for WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        Client client = new Client();
        public WorkWindow(Client c)
        {
            InitializeComponent();
            client = c;
        }

        private void btn_AddDiagnosisClick(object sender, RoutedEventArgs e)
        {
            AddDiagnosis addDiagnosis = new AddDiagnosis(client);
            addDiagnosis.Show();
        }
    }
}
