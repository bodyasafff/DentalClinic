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
        public MainWindow()
        {
            InitializeComponent();
            using (Service1Client service1Client = new Service1Client())
            {
                 ClientConstList.Clients = service1Client.GetAllClients().ToList();
            }
        }
        private void btn_SignUpClick(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }

        private void btn_SignInClick(object sender, RoutedEventArgs e)
        {
            bool chak = false;
            foreach (var item in ClientConstList.Clients)
            {
                if(item.Login == txt_Login.Text && item.Password == txt_Password.Password)
                {
                    WorkWindow workWindow = new WorkWindow();
                    workWindow.Show();
                    chak = true;
                    Close();
                    break;
                }
            }
            if(chak == false)
            {
                MessageBox.Show("Логін або пароль введені не правильно","Увага!");
            }
        }
    }
}
