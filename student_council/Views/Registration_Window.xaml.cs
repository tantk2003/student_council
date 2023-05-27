using System;
using student_council.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace student_council.Views
{
    /// <summary>
    /// Логика взаимодействия для Registration_Window.xaml
    /// </summary>
    public partial class Registration_Window : Window
    {
        public users user = null;
        public Registration_Window()
        {
            InitializeComponent();
            faculty_reg.ItemsSource = student_council_kitEntities.GetContext().faculties.ToList();
}
        private void btn_signup_Click(object sender, RoutedEventArgs e)
{
            if ((name_reg.Text == "" || surname_reg.Text == "" || patronmic_reg.Text == "" || faculty_reg.Text == null || Convert.ToInt32(numgroup_reg.Text) == 0 || email_reg.Text == "" || login_reg.Text == "" || password_reg.Text == ""))
            {
                MessageBox.Show("Пустые данные");

            }
            else
            {
                var user = student_council_kitEntities.GetContext().users.Where(x =>x.email == email_reg.Text).FirstOrDefault();
                    
                if (user != null)
                {
                    MessageBox.Show("Введенная почта уже существует!");
                }
                else
                {   
                    if (Registration_and_Autorization.SignUp(name_reg.Text, surname_reg.Text, patronmic_reg.Text, faculty_reg.Text, Convert.ToInt32(numgroup_reg.Text), email_reg.Text, login_reg.Text, password_reg.Text))
                    {
                        MessageBox.Show("Пользователь зарегистрирован!");
                        AutorizationWindow autorizationWindow = new AutorizationWindow();
                        Hide();
                        autorizationWindow.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Неудачная попытка регистрации!");
                    }
                }
              
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow autorizationWindow= new AutorizationWindow();
            Hide();
            autorizationWindow.Show();
        }

        private void name_reg_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Create_EventWindow.IsNumber(e.Text))
            {
                e.Handled = true;
            }

            Regex regex = new Regex("[^а-яА-Я]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void numgroup_reg_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Create_EventWindow.IsNumber(e.Text))
            {
                e.Handled = true;
            }
        }

        private void email_reg_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
             Regex regex = new Regex("[^a-zA-Z0-9.@-]");
                        e.Handled = regex.IsMatch(e.Text);
        }
    }
}
