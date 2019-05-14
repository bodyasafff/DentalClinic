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
    /// Interaction logic for SetDoc.xaml
    /// </summary>
    public partial class SetDoc : Window
    {
        ModelClient Client = new ModelClient();
        public SetDoc(ModelClient c)
        {
            InitializeComponent();
            Client = c;
        }

        private void btn_SetDocClick(object sender, RoutedEventArgs e)
        {
            Client.DoctorName = txt_DocName.Text;
            Client.DoctoorStatus = txt_DocStatus.Text;
            using (Service1Client service1Client = new Service1Client())
            {
                service1Client.AddDocToClient(Client);
            }
            WorkWindow workWindow = new WorkWindow(Client);
            workWindow.Show();
            Close();
        }

    }
}
