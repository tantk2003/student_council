using student_council.Models;
using student_council.Views;
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
using student_council.Controllers;
using System.Text.RegularExpressions;

namespace student_council.Views
{
/// <summary>
/// Логика взаимодействия для Personal_AccountWindow.xaml
/// </summary>
    public partial class Personal_AccountWindow : Window
    {
        public faculties faculty = null;
        public event_change_View selected_event = null;
        public Personal_AccountWindow(users user)
        {
            InitializeComponent();
            if (user.role == "Студсоветчик")
            {
                btn_create_event.Visibility = Visibility.Visible;
                btn_student_list.Visibility = Visibility.Visible;
                btn_all_events.Visibility = Visibility.Hidden;
                btn_my_events.Visibility = Visibility.Hidden;
                btn_directions.Visibility = Visibility.Hidden;
                btn_create_rehearsals.Visibility = Visibility.Visible;
                btn_direction_participants.Visibility = Visibility.Visible;
                btn_change.Visibility = Visibility.Visible;
                btn_events_ch.Visibility = Visibility.Visible;
            }
            else if(user.role == "Председатель")
            {
                btn_create_event.Visibility = Visibility.Hidden;
                btn_enter_histiry.Visibility = Visibility.Visible;
                btn_posts.Visibility = Visibility.Visible;
                btn_student_council.Visibility = Visibility.Visible;
                btn_my_events.Visibility= Visibility.Hidden;
                btn_all_events.Visibility = Visibility.Visible;
                btn_student_list.Visibility=Visibility.Hidden;
                btn_directions.Visibility = Visibility.Hidden;
                btn_create_rehearsals.Visibility = Visibility.Hidden;
                btn_rehearsals.Visibility=Visibility.Hidden;
                btn_direction_participants.Visibility = Visibility.Hidden;
                btn_change.Visibility = Visibility.Visible;
                btn_events_ch.Visibility = Visibility.Hidden;
            }
            else
            {
                btn_all_events.Visibility = Visibility.Visible;
                btn_my_events.Visibility = Visibility.Visible;
                btn_create_event.Visibility = Visibility.Hidden;
                btn_student_list.Visibility = Visibility.Hidden;
                btn_directions.Visibility = Visibility.Visible;
                btn_create_rehearsals.Visibility = Visibility.Hidden;
                btn_rehearsals.Visibility=Visibility.Visible;
                btn_direction_participants.Visibility = Visibility.Hidden;
                btn_change.Visibility = Visibility.Visible;
                btn_events_ch.Visibility = Visibility.Hidden;
            }
            DataContext = user;
            using (student_council_kitEntities db = new student_council_kitEntities())
            {
                 faculty = db.faculties.ToList().FirstOrDefault(x => (x.id_faculty == user.id_faculty));
            }
            tblock_faculty.Text = faculty.name_faculty;
            cbox_events.ItemsSource = student_council_kitEntities.GetContext().events.ToList();
            cbox_dir.ItemsSource = student_council_kitEntities.GetContext().directions.ToList();
            DGridEvent.ItemsSource = student_council_kitEntities.GetContext().event_change_View.ToList();
        }
        public Personal_AccountWindow()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow autorizationWindow = new AutorizationWindow();
            Hide();
            autorizationWindow.Show();
        }

        private void btn_all_events_Click(object sender, RoutedEventArgs e)
        {
            DirectoriesWindow directoriesWindow = new DirectoriesWindow();
            Hide();
            directoriesWindow.Show();
        }

        private void btn_create_event_Click(object sender, RoutedEventArgs e)
        {
            Create_EventWindow createEventWindow = new Create_EventWindow();
            Hide();
            createEventWindow.Show();
        }

        private void btn_my_events_Click(object sender, RoutedEventArgs e)
        {
            My_EventsWindow my_EventsWindow = new My_EventsWindow(AutorizationWindow.user);
            Hide();
            my_EventsWindow.Show();
        }

        private void btn_student_council_Click(object sender, RoutedEventArgs e)
        {
            Сomposition_of_Student_CouncilWindow сomposition_Of_Student_CouncilWindow = new Сomposition_of_Student_CouncilWindow();
            Hide();
            сomposition_Of_Student_CouncilWindow.Show();
        }

        private void btn_posts_Click(object sender, RoutedEventArgs e)
        {
            PostsWindow postsWindow = new PostsWindow();
            Hide();
            postsWindow.Show();
        }

        private void btn_enter_histiry_Click(object sender, RoutedEventArgs e)
        {
            Enter_HistoryWindow enterHistoryWindow = new Enter_HistoryWindow();
            Hide();
            enterHistoryWindow.Show();
        }

        private void btn_directions_Click(object sender, RoutedEventArgs e)
        {
            Direction_RecordWindow direction_RecordWindow = new Direction_RecordWindow(AutorizationWindow.user);
            Hide();
            direction_RecordWindow.Show();
        }

        private void btn_create_rehearsals_Click(object sender, RoutedEventArgs e)
        {
            RehearsalsWindow rehearsalsWindow = new RehearsalsWindow();
            Hide();
            rehearsalsWindow.Show();
        }

        private void btn_rehearsals_Click(object sender, RoutedEventArgs e)
        {
            My_RehearsalsWindow1 my_RehearsalsWindow1 = new My_RehearsalsWindow1(AutorizationWindow.user);
            Hide();
            my_RehearsalsWindow1.Show();
        }
        private void btn_student_list_Click(object sender, RoutedEventArgs e)
        {
            spanel_user_info.Visibility = Visibility.Hidden;
            spanel_btns.Visibility = Visibility.Hidden;
            spanel_print.Visibility = Visibility.Visible;
            btn_back.Visibility = Visibility.Visible;
        }

        private void btn_print_Click(object sender, RoutedEventArgs e)
        {
            string eventt = cbox_events.Text;
            var event_list = student_council_kitEntities.GetContext().events_stud_View.Where(x => x.Expr1 == eventt).ToList();
            if (event_list.Count == 0)
            {
                MessageBox.Show("Участники отсутствуют!");
            }
            else
            {
                int count = event_list.Count;
                FlowDocumentScrollViewer report = new FlowDocumentScrollViewer();
                FlowDocument doc = new FlowDocument();
                StackPanel container = new StackPanel
                {
                    Margin = new Thickness(80),
                    VerticalAlignment = VerticalAlignment.Top,
                    Orientation = Orientation.Vertical
                };
                TextBlock headline = new TextBlock
                {
                    FontWeight = FontWeights.Medium,
                    Margin = new Thickness(0, 40, 0, 40),
                    FontFamily = new FontFamily("Arial"),
                    FontSize = 20
                };
                headline.Text = $"Количество участников: {count}";
                container.Children.Add(headline);
                DataGrid table = new DataGrid
                {
                    FontFamily = new FontFamily("Arial"),
                    FontSize = 16,
                    ColumnHeaderStyle = (Style)FindResource("data_grid_column")
                };
                DataGridTextColumn surnameColumn = new DataGridTextColumn
                {
                    Header = "Фамилия",
                    Width = DataGridLength.Auto
                };
                Binding binding = new Binding();
                binding.Path = new PropertyPath("surname");
                surnameColumn.Binding = binding;
                DataGridTextColumn nameColumn = new DataGridTextColumn
                {
                    Header = "Имя",
                    Width = DataGridLength.Auto
                };
                binding = new Binding();
                binding.Path = new PropertyPath("name");
                nameColumn.Binding = binding;
                DataGridTextColumn patronymicColumn = new DataGridTextColumn
                {
                    Header = "Отчество",
                    Width = DataGridLength.Auto
                };
                binding = new Binding();
                binding.Path = new PropertyPath("patronymic");
                patronymicColumn.Binding = binding;
                DataGridTextColumn num_groupColumn = new DataGridTextColumn
                {
                    Header = "Номер группы",
                    Width = DataGridLength.Auto
                };
                binding = new Binding();
                binding.Path = new PropertyPath("num_group");
                num_groupColumn.Binding = binding;
                table.Columns.Add(surnameColumn);
                table.Columns.Add(nameColumn);
                table.Columns.Add(patronymicColumn);
                table.Columns.Add(num_groupColumn);
                table.ItemsSource = event_list;
                table.AutoGenerateColumns = false;
                container.Children.Add(table);
                BlockUIContainer blockUIContainer = new BlockUIContainer(container);
                doc.Blocks.Add(blockUIContainer);
                report.Document = doc;
                report.Print();
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            spanel_print.Visibility = Visibility.Hidden;
            spanel_user_info.Visibility = Visibility.Visible;
            spanel_btns.Visibility = Visibility.Visible;
            btn_back.Visibility = Visibility.Hidden;
            btn_exit.Visibility = Visibility.Visible;
            spanel_info.Visibility = Visibility.Hidden;
            spanel_direction.Visibility = Visibility.Hidden;
            DGridDir.Visibility = Visibility.Hidden;
            DGridEvent.Visibility = Visibility.Hidden;
        }

        private void btn_direction_participants_Click(object sender, RoutedEventArgs e)
        {
            spanel_user_info.Visibility = Visibility.Hidden;
            spanel_btns.Visibility = Visibility.Hidden;
            spanel_direction.Visibility = Visibility.Visible;
            btn_back.Visibility = Visibility.Visible;
            btn_exit.Visibility = Visibility.Hidden;
            DGridDir.Visibility = Visibility.Visible;
            spanel_info.Visibility = Visibility.Visible;
           
        }

        private void btn_info_dgrid_Click(object sender, RoutedEventArgs e)
        {
            string dir = cbox_dir.Text;
            var direction = student_council_kitEntities.GetContext().direction_stud_View.Where(x => x.name_direction == dir).ToList();
            DGridDir.ItemsSource = direction;
        }

        private void btn_change_Click(object sender, RoutedEventArgs e)
        {

            cbox_faculty2.Visibility = Visibility.Visible;
            surname_reg2.Visibility = Visibility.Visible;
            name_reg2.Visibility= Visibility.Visible;
            patronimic_reg2.Visibility = Visibility.Visible;
            tbox_num.Visibility = Visibility.Visible;
            tbox_email.Visibility = Visibility.Visible;
            btn_save.Visibility = Visibility.Visible;

            name_reg.Visibility = Visibility.Hidden;
            surname_reg.Visibility = Visibility.Hidden;
            patronimic_reg.Visibility = Visibility.Hidden;
            tblock_faculty.Visibility = Visibility.Hidden;
            tblock_num.Visibility = Visibility.Hidden;
            tblock_email.Visibility = Visibility.Hidden;
            cbox_faculty2.ItemsSource = student_council_kitEntities.GetContext().faculties.ToList();

        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            var faculty1 = cbox_faculty2.SelectedIndex+1;
            var id_faculties = student_council_kitEntities.GetContext().faculties.Where(x => x.id_faculty == faculty1).FirstOrDefault();
      
            Manipulation_BD.ChangeUser(name_reg2.Text, surname_reg2.Text, patronimic_reg2.Text, id_faculties, Convert.ToInt32(tbox_num.Text), tbox_email.Text, AutorizationWindow.user);

            name_reg.Visibility = Visibility.Visible;
            surname_reg.Visibility = Visibility.Visible;
            patronimic_reg.Visibility = Visibility.Visible;
            tblock_faculty.Visibility = Visibility.Visible;
            tblock_num.Visibility = Visibility.Visible;
            tblock_email.Visibility = Visibility.Visible;
            tblock_faculty.Text = id_faculties.name_faculty;

            cbox_faculty2.Visibility = Visibility.Hidden;
            surname_reg2.Visibility = Visibility.Hidden;
            name_reg2.Visibility = Visibility.Hidden;
            patronimic_reg2.Visibility = Visibility.Hidden;
            tbox_num.Visibility = Visibility.Hidden;
            tbox_email.Visibility = Visibility.Hidden;
            btn_save.Visibility = Visibility.Hidden;
   
        }

        private void name_reg2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Create_EventWindow.IsNumber(e.Text))
            {
                e.Handled = true;
            }

            Regex regex = new Regex("[^а-яА-Я]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tbox_num_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Create_EventWindow.IsNumber(e.Text))
            {
                e.Handled = true;
            }
        }

        private void btn_events_ch_Click(object sender, RoutedEventArgs e)
        {
            spanel_btns.Visibility = Visibility.Hidden;
            spanel_info.Visibility = Visibility.Hidden;
            DGridDir.Visibility = Visibility.Hidden;
            spanel_direction.Visibility = Visibility.Hidden;
            btn_exit.Visibility = Visibility.Hidden;
            DGridEvent.Visibility = Visibility.Visible;
            btn_back.Visibility = Visibility.Visible;
            spanel_user_info.Visibility = Visibility.Hidden;

        }

        private void btn_change_event_Click(object sender, RoutedEventArgs e)
        {
            DGridEvent.Visibility = Visibility.Hidden;
            spanel_change_event.Visibility = Visibility.Visible;
            selected_event = (sender as Button).DataContext as event_change_View;
            var event_del = student_council_kitEntities.GetContext().events.FirstOrDefault(x => x.id_event == selected_event.id_event);
            var desteny = student_council_kitEntities.GetContext().distiny.FirstOrDefault(x => x.id_distiny == selected_event.id_destiny);
            string name_distiny = desteny.name_distiny;
            cbox_direction.Text = selected_event.name;
            cbox_direction.ItemsSource = student_council_kitEntities.GetContext().directions.ToList();
            tbox_name.Text = selected_event.name_event;
            tbox_description.Text = selected_event.description;
            cbox_destiny.Text = name_distiny;
            cbox_destiny.ItemsSource = student_council_kitEntities.GetContext().distiny.ToList();
            tbox_num_place.Text = Convert.ToString(selected_event.num_place);

        }

        private void btn_delete_event_Click(object sender, RoutedEventArgs e)
        {
            selected_event = (sender as Button).DataContext as event_change_View;
            var event_del = student_council_kitEntities.GetContext().events.FirstOrDefault(x => x.id_event == selected_event.id_event);
            student_council_kitEntities.GetContext().events.Remove(event_del);
            student_council_kitEntities.GetContext().SaveChanges();
            DGridEvent.ItemsSource = null;
            student_council_kitEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            DGridEvent.ItemsSource = student_council_kitEntities.GetContext().event_change_View.ToList();
        }

        private void btn_change_event_form_Click(object sender, RoutedEventArgs e)
        {
            
            if (cbox_direction.SelectedIndex + 1 == 0 || tbox_name.Text == null || tbox_description.Text == null || Convert.ToDateTime(dpicker_date.Text) == null || cbox_destiny.SelectedIndex + 1 == 0 || Convert.ToInt32(tbox_num_place.Text) == 0)
            {
                MessageBox.Show("Вы не ввели данные!");
            }
            else
            {
                if(Convert.ToDateTime(dpicker_date.Text) < DateTime.Now)
                {
                    MessageBox.Show("Дата не может быть позже нынешней!");
                }
                Manipulation_BD.ChangeEvent(selected_event.id_event, cbox_direction.SelectedIndex + 1, tbox_name.Text, tbox_description.Text, Convert.ToDateTime(dpicker_date.Text), cbox_destiny.SelectedIndex + 1, Convert.ToInt32(tbox_num_place.Text));
            }
            spanel_change_event.Visibility = Visibility.Hidden;
            DGridEvent.Visibility = Visibility.Visible;
            DGridEvent.ItemsSource = null;
            student_council_kitEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            DGridEvent.ItemsSource = student_council_kitEntities.GetContext().event_change_View.ToList();

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
