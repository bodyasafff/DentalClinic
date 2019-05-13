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
using WcfService1.ModelsToMap;
using WpfDentalClinicC.ServiceReference1;


namespace WpfDentalClinicC
{
    /// <summary>
    /// Interaction logic for EditClientWindow.xaml
    /// </summary>
    public partial class EditClientWindow : Window
    {
        ModelClient modelClient = new ModelClient();
        public EditClientWindow(ModelClient mc)
        {
            InitializeComponent();
            modelClient = mc;
            txt_Name.Text = modelClient.Name;
            txt_SurName.Text = modelClient.SurName;
            txt_Phone.Text = modelClient.Phone;
            txt_Email.Text = modelClient.Email;
            txt_Country.Text = modelClient.Country;
            txt_City.Text = modelClient.City;
            txt_Street.Text = modelClient.Street;
        }
        private void btn_EditClient_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Name.Text))
                txt_Name.Focus();
            else if (String.IsNullOrEmpty(txt_SurName.Text))
                txt_SurName.Focus();
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
                ModelClient m = new ModelClient();
                m.Id = modelClient.Id;
                m.Name = txt_Name.Text;
                m.SurName = txt_SurName.Text;
                m.Phone = txt_Phone.Text;
                m.Email = txt_Email.Text;
                m.Country = txt_Country.Text;
                m.City = txt_City.Text;
                m.Street = txt_Street.Text;
                Service1Client service1Client = new Service1Client();
                service1Client.EditClient(m);
                WorkWindow workWindow = new WorkWindow(m);
                workWindow.Show();
                Close();
            }
        }
    }
}
