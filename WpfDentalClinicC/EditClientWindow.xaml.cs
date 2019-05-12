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

        }
    }
}
