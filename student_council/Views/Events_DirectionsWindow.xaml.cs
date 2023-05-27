using System;
using student_council.Views;
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

namespace student_council.Views
{
    /// <summary>
    /// Логика взаимодействия для Events_DirectionsWindow.xaml
    /// </summary>
    public partial class Events_DirectionsWindow : Window
    {
        public Events_DirectionsWindow(directions selectedDirection)
        {
            InitializeComponent();
            if (AutorizationWindow.user.id_faculty != 4)
            {
                var grid_event = student_council_kitEntities.GetContext().events.Where(x => x.id_destiny == 2 && x.id_direction == selectedDirection.id_direction).ToList();
                dgrid_events.ItemsSource = grid_event;
            }
            else
            {
                var enableEvents = student_council_kitEntities.GetContext().events.Where(x => x.id_direction == selectedDirection.id_direction).ToList();
                dgrid_events.ItemsSource = enableEvents;
            }
        }

        private void dgrid_events_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
           var selectedEvent = dgrid_events.SelectedItems.Cast<events>().ToList();
            foreach (var item in selectedEvent)
            {
                tblock_name.Text = item.name;
                tblock_description.Text = item.description;
                tblock_date.Text = Convert.ToString(item.date);
                tblock_num_place.Text = Convert.ToString(item.num_place);
                tblock_status.Text = item.status_event.name_status;
            }
        }

        private void btn_enroll_Click(object sender, RoutedEventArgs e)
        {
            int num_place = 0;
            int id_event = 0;
            var selectedEvent = dgrid_events.SelectedItems.Cast<events>().ToList();
            foreach(var item in selectedEvent)
            {
                id_event = item.id_event;
            }
            if(Enroll_and_Other.Enroll(selectedEvent,AutorizationWindow.user))
            {
                MessageBox.Show("Вы успешно записались на данное мероприятие!");
                student_council_kitEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                var new_info = student_council_kitEntities.GetContext().events.Where(x => x.id_event == id_event).ToList();
                foreach(var item in new_info)
                {
                    num_place = item.num_place;
                }
                tblock_num_place.Text = Convert.ToString(num_place);
            }
            else
            {
                MessageBox.Show("Ошбка! Вы уже записаны на это мероприятие.");
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            DirectoriesWindow directoriesWindow = new DirectoriesWindow();
            Hide();
            directoriesWindow.Show();
        }
    }
}
