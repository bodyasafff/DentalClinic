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
using WpfDentalClinicC.ServiceReference1;

namespace WpfDentalClinicC
{
    /// <summary>
    /// Interaction logic for AddDiagnosis.xaml
    /// </summary>
    public class DiagnosisInfo
    {
        string NameDiagnosis { get; set; }
        string DescDiagnosi { get; set; }
    }
    public partial class AddDiagnosis : Window
    {
        ModelClient Client = new ModelClient();
        public AddDiagnosis(ModelClient c)
        {
            List<DiagnosisInfo> diagnosisInfosToGrid = new List<DiagnosisInfo>(); 
            InitializeComponent();
            Client = c;
            Lb_Diagnosis.ItemsSource = c.DiagnosisName;
        }

        private void btn_AddDiagnosisClick(object sender, RoutedEventArgs e)
        {
            using (Service1Client service1Client = new Service1Client())
            {
                service1Client.AddDiagnosis(Client.Id,txt_NameDiagnosis.Text,txt_Description.Text);
                Close();
            }
        }
    }
}
