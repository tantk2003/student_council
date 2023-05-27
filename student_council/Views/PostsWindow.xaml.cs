using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

namespace student_council.Views
{
    /// <summary>
    /// Логика взаимодействия для PostsWindow.xaml
    /// </summary>
    public partial class PostsWindow : Window
    {
        public List<Free_Posts> free_Posts = new List<Free_Posts>();
        public posts_stud_View selected_user = null;
        public PostsWindow()
        {
            InitializeComponent();
            int? id_post = null;
            string name_post = null;
            DGridPosts.ItemsSource = student_council_kitEntities.GetContext().posts_stud_View.ToList();
            free_Posts.Clear();
            var post = student_council_kitEntities.GetContext().posts.ToList();
            foreach (var item in post)
            {
                id_post = item.id_post;
                name_post = item.name_post;
                var user_post = student_council_kitEntities.GetContext().posts_stud_View.FirstOrDefault(x => x.id_post == id_post);
                if (user_post == null)
                {
                    free_Posts.Add(new Free_Posts { id_post = id_post, name_post = name_post });
                }
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(AutorizationWindow.user);
            Hide();
            personal_AccountWindow.Show();
        }

        public void btn_add_post_Click(object sender, RoutedEventArgs e)
        {
            int? id_post = null;
            int id_user = 0;
            string name_post = null;
            var user_post = student_council_kitEntities.GetContext().posts_stud_View.ToList();
            selected_user = (sender as Button).DataContext as posts_stud_View;
            var stud_council = student_council_kitEntities.GetContext().student_council.ToList();

            id_user = selected_user.id_user;
            id_post = selected_user.id_post;
            name_post = selected_user.name_post;

            var user = student_council_kitEntities.GetContext().posts_stud_View.FirstOrDefault(x => x.id_user == id_user);

            if (user.id_post == null)
            {
                if (free_Posts.Count > 0)
                {
                    DGridPosts.Visibility = Visibility.Hidden;
                    spanel_post.Visibility = Visibility.Visible;
                    tblock_surname.Text = user.surname;
                    tblock_name.Text = user.name;
                    tblock_patronymic.Text = user.patronymic;
                    cbox_free_post.ItemsSource = free_Posts;
                }
                else
                {
                    MessageBox.Show("Нет свободных должностей!");
                }
            }
            else
            {
                MessageBox.Show("У пользователя уже есть должность!");
            }
        }

        private void btn_delete_post_Click(object sender, RoutedEventArgs e)
        {
            int? id_post = null;
            int id_user = 0;
            string name_post = null;
            selected_user = (sender as Button).DataContext as posts_stud_View;
            var stud_council = student_council_kitEntities.GetContext().student_council.ToList();


            id_user = selected_user.id_user;
            id_post = selected_user.id_post;
            name_post = selected_user.name_post;

            var user_post = student_council_kitEntities.GetContext().posts_stud_View.FirstOrDefault(x => x.id_user == id_user && x.id_post == id_post);
            var user = student_council_kitEntities.GetContext().student_council.FirstOrDefault(x => x.id_user == id_user);
            if (user_post.id_post != null)
            {
                user.id_post = null;
                free_Posts.Add(new Free_Posts { id_post = id_post, name_post = name_post });
                student_council_kitEntities.GetContext().SaveChanges();
                MessageBox.Show("Должность убрана.");
            }
            else
            {
                MessageBox.Show("У пользователя нет должности!");
            }
            DGridPosts.ItemsSource = null;
            student_council_kitEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            DGridPosts.ItemsSource = student_council_kitEntities.GetContext().posts_stud_View.ToList();
        }

        public void btn_add_post_user_Click(object sender, RoutedEventArgs e)
        {
            int? id_post = null;
            int id_user = 0;
            string name_post = null;
            var stud_council = student_council_kitEntities.GetContext().student_council.ToList();

            id_user = selected_user.id_user;
            id_post = selected_user.id_post;
            name_post = selected_user.name_post;

            var user_post = student_council_kitEntities.GetContext().posts_stud_View.FirstOrDefault(x => x.id_user == id_user);
            var selected_post = cbox_free_post.Text;
            Enroll_and_Other.Add_Post(selected_post, id_user);
            free_Posts.Remove(new Free_Posts { id_post = id_post, name_post = name_post });
            spanel_post.Visibility = Visibility.Hidden;
            DGridPosts.Visibility = Visibility.Visible;
            DGridPosts.ItemsSource = null;
            student_council_kitEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            DGridPosts.ItemsSource = student_council_kitEntities.GetContext().posts_stud_View.ToList();
        }
    }
}
