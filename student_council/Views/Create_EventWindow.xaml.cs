using System;
using student_council.Controllers;
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
using System.Text.RegularExpressions;

namespace student_council.Views
{
    /// <summary>
    /// Логика взаимодействия для Create_EventWindow.xaml
    /// </summary>
    public partial class Create_EventWindow : Window
    {
        public Create_EventWindow()
        {
            InitializeComponent();
            cbox_direction.ItemsSource = student_council_kitEntities.GetContext().directions.ToList();
            cbox_destiny.ItemsSource = student_council_kitEntities.GetContext().distiny.ToList();
        }

        private void btn_add_event_Click(object sender, RoutedEventArgs e)
        {
            if ((cbox_direction.SelectedIndex + 1 == 0 || tbox_name.Text == "" || tbox_description.Text == "" || Convert.ToDateTime(dpicker_date.Text) == null || cbox_destiny.SelectedIndex + 1 == 0 || Convert.ToInt32(tbox_num_place.Text) == 0))
            {
                MessageBox.Show("Пустые данные");

            }
            else
            {                
                if (Manipulation_BD.AddEvent(cbox_direction.SelectedIndex + 1, tbox_name.Text, tbox_description.Text, Convert.ToDateTime(dpicker_date.Text), cbox_destiny.SelectedIndex + 1, Convert.ToInt32(tbox_num_place.Text)))
                {
                    MessageBox.Show("Мероприятие успешно создано!");
                }
                else
                {
                    MessageBox.Show("Ошибка! Повторите попытку.");
                }
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(AutorizationWindow.user);
            Hide();
            personal_AccountWindow.Show();
        }

        private void tbox_num_place_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsNumber(e.Text))
            {
                e.Handled = true;
            }
        }
        public static bool IsNumber(string input)
        {
            return int.TryParse(input, out int result);
        }

        private void tbox_name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (IsNumber(e.Text))
            {
                e.Handled = true;
            }
        }

        private void tbox_description_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
