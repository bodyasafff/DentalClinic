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
using WcfService1.Models;
using WcfService1.ModelsToMap;

namespace WpfDentalClinicC
{
    /// <summary>
    /// Interaction logic for WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        ModelClient client = new ModelClient();
        public WorkWindow(ModelClient c)
        {
            InitializeComponent();
            client = c;
            FillTextBoxs();
        }

        private void btn_AddDiagnosisClick(object sender, RoutedEventArgs e)
        {
            AddDiagnosis addDiagnosis = new AddDiagnosis(client);
            addDiagnosis.Show();
        }
        private void FillTextBoxs()
        {
            txt_Name.Text = client.Name;
            txt_SurName.Text = client.SurName;
            txt_Phone.Text = client.Phone;
            //txt_Doctor.Text = client.Doctor.Name;
            txt_Email.Text = client.Email;
            txt_AdressCountry.Text = client.Country;
            txt_AdressCity.Text = client.City;
            txt_AdressStreet.Text = client.Street;
        }

        private void btn_ExitClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btn_EdtitClientClick(object sender, RoutedEventArgs e)
        {
            EditClientWindow editClientWindow = new EditClientWindow(client);
            editClientWindow.Show();
            Close();
            //txt_Name.Text = editClientWindow.txt_Name.Text;
        }
    }
}
