using student_council.Models;
using student_council.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace student_council.Views
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public int randomNumber = 0;
        public users user_for = null;
        public int counter = 0;
        public static users user = null;
        public AutorizationWindow()
        {
            InitializeComponent();
            var events = student_council_kitEntities.GetContext().events.ToList();
            foreach(var item in events)
            {
                if(item.date < DateTime.Now)
                {
                    item.id_status = 1;
                }
                else if (item.date == DateTime.Now)
                {
                    item.id_status = 2;
                }
                student_council_kitEntities.GetContext().SaveChanges();
            }
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            string pass = "";
            if(counter == 0)
            {
                pass = tbox_password.Password;
            }
            else
            {
                pass = tbox_pass_open.Text;
            }
            if (Registration_and_Autorization.Login(tbox_login.Text, pass))
            {
                MessageBox.Show("Вход выполнен успешно!");
                using (student_council_kitEntities db = new student_council_kitEntities())
                {
                     user = db.users.ToList().FirstOrDefault(x => (x.login == tbox_login.Text));
                }
                Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(user);
                Hide();
                personal_AccountWindow.Show();
            }
            else
            {
                MessageBox.Show("Повторите попытку!");
            }

        }

        private void Create_button_Click(object sender, RoutedEventArgs e)
        {
            Registration_Window registration_Window = new Registration_Window();
            Hide();
            registration_Window.Show();
        }

        private void btn_show_pass_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                tbox_pass_open.Visibility = Visibility.Visible;
                tbox_pass_open.Text = tbox_password.Password;
                tbox_password.Visibility = Visibility.Hidden;
            }
            else
            {
                tbox_password.Visibility = Visibility.Visible;
                tbox_password.Password = tbox_pass_open.Text;
                tbox_pass_open.Visibility = Visibility.Hidden;
                counter = 0;
            }
        }

        private void btn_forget_password_Click(object sender, RoutedEventArgs e)
        {
            spanel_autorisation.Visibility = Visibility.Hidden;
            spanel_send_code.Visibility = Visibility.Visible;
        }

        private void btn_send_code_Click(object sender, RoutedEventArgs e)
        {
            string email = tbox_email.Text;
            user_for = student_council_kitEntities.GetContext().users.FirstOrDefault(x => x.email == email);
            if(user_for == null)
            {
                MessageBox.Show("Пользователь не найден!");
            }
            else
            {
                Random rnd = new Random();
                randomNumber = rnd.Next(0001, 9999);
                Enroll_and_Other.SendCode(email, randomNumber);
                tbox_code.Visibility = Visibility.Visible;
                btn_new_password.Visibility = Visibility.Visible;
            }
        }

        private void btn_new_password_Click(object sender, RoutedEventArgs e)
        {
            if(tbox_code.Text == Convert.ToString(randomNumber))
            {
                spanel_send_code.Visibility = Visibility.Hidden;
                tbox_code = null;
                tbox_email = null;
                tbox_code.Visibility=Visibility.Hidden;
                btn_new_password.Visibility=Visibility.Hidden;
                spanel_new_password.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Введен неверный код восстановления!");
            }
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            string password = tbox_new_password.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed sha256 = new SHA256Managed();
            byte[] Hash = sha256.ComputeHash(bytes);
            var hash = Convert.ToBase64String(Hash);
            user_for.password = hash;
            student_council_kitEntities.GetContext().SaveChanges();
            MessageBox.Show("Пароль успешно изменен!");
            spanel_new_password.Visibility = Visibility.Hidden;
            spanel_autorisation.Visibility = Visibility.Visible;
        }

        private void tbox_login_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9.@-]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
