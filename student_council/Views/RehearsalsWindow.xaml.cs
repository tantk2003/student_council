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
using student_council.Models;
using student_council.Controllers;
using System.Net.Sockets;

namespace student_council.Views
{
    /// <summary>
    /// Логика взаимодействия для RehearsalsWindow.xaml
    /// </summary>
    public partial class RehearsalsWindow : Window
    {
        public List<Users_Rehearsals> users_Rehearsals = new List<Users_Rehearsals>();
        public List<users> user = student_council_kitEntities.GetContext().users.ToList();
        public RehearsalsWindow()
        {
            InitializeComponent();
            DGridUsers.ItemsSource = student_council_kitEntities.GetContext().users.ToList();
        }

        private void btn_delete_item_user_Click(object sender, RoutedEventArgs e)
        {
            var delete_item_user = ((sender as Button).DataContext as Users_Rehearsals);
            users_Rehearsals.Remove(delete_item_user);
            DGridUsers.ItemsSource = users_Rehearsals.ToList();
        }

        private void btn_create_record_Click(object sender, RoutedEventArgs e)
        {
            var selected_users = DGridUsers.SelectedItems.Cast<users>().ToList();
            Enroll_and_Other.AddRehearsal(selected_users, Convert.ToDateTime(dpicker_date.Text));

        }

        private void btn_cansel_Click(object sender, RoutedEventArgs e)
        {
            Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(AutorizationWindow.user);
            Hide();
            personal_AccountWindow.Show();
        }

       
    }
}
