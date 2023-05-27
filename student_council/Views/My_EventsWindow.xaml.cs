using student_council.Models;
using student_council.Controllers;
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

namespace student_council.Views
{
    /// <summary>
    /// Логика взаимодействия для My_EventsWindow.xaml
    /// </summary>
    public partial class My_EventsWindow : Window
    {
        public users currentUser = new users();
        public My_EventsWindow(users user)
        {
            InitializeComponent();
            currentUser = user;
            DGridMyEvents.ItemsSource = student_council_kitEntities.GetContext().events_stud_View.Where(x => (x.id_user == user.id_user)).ToList();
            var selectedEvent = DGridMyEvents.SelectedItems.Cast<events>().ToList();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(AutorizationWindow.user);
            Hide();
            personal_AccountWindow.Show();
        }

        private void btn_cancel_record_Click(object sender, RoutedEventArgs e)
        {
            var selectedEvent = DGridMyEvents.SelectedItems.Cast<events_stud_View>().ToList();
            if (Manipulation_BD.DeleteRecord(selectedEvent, AutorizationWindow.user))
            {
                MessageBox.Show("Запись удалена");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
            DGridMyEvents.ItemsSource = student_council_kitEntities.GetContext().events_stud_View.Where(x => (x.id_user == currentUser.id_user)).ToList();
        }
    }
}
