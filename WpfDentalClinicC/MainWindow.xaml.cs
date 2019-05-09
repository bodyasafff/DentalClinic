using System.Windows;
using WcfService1.ModelsToMap;
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
        private void Btn_SignUpClick(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }

        private void Btn_SignInClick(object sender, RoutedEventArgs e)
        {
            using (Service1Client service1Client = new Service1Client())
            {
                bool Chak = service1Client.LogIn(txt_Login.Text,txt_Password.Password);
                if(Chak == true)
                {
                    ModelClient client = service1Client.GetClient(txt_Login.Text, txt_Password.Password);
                    if (client != null)
                    {
                        WorkWindow workWindow = new WorkWindow(client);
                        workWindow.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка))))");
                    }
                }
                else
                {
                    MessageBox.Show("Не праавильно ввеедений логін, або пароль");
                }
            }
        }
    }
}
