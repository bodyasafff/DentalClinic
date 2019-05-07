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
        } 
        private void btn_SignUpClick(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }

        private void btn_SignInClick(object sender, RoutedEventArgs e)
        {
            using (Service1Client service1Client = new Service1Client())
            {
                bool Chak = service1Client.LogIn(txt_Login.Text,txt_Password.Password);
                if(Chak == true)
                { 
                    WorkWindow workWindow = new WorkWindow();
                    workWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Не праавильно ввеедений логін, або пароль");
                }
            }
        }
    }
}
