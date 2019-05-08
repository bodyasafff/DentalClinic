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

namespace WpfDentalClinicC
{
    /// <summary>
    /// Interaction logic for AddDiagnosis.xaml
    /// </summary>
    public partial class AddDiagnosis : Window
    {
        Client Client = new Client();
        public AddDiagnosis(Client c)
        {
            InitializeComponent();
            Client = c;
        }
    }
}
