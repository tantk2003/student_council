using student_council.Views;
using student_council.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
using System.Xml.Linq;
using System.Security.Cryptography;

namespace student_council.Models
{
    public class Registration_and_Autorization
    {
        public static bool Login(string login, string password)
        {
            if (login == "" && password == "")
            {
                MessageBox.Show("Вы не ввели данные!");
                return false;
            }
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed sha256 = new SHA256Managed();
            byte[] Hash = sha256.ComputeHash(bytes);
            var hash = Convert.ToBase64String(Hash);
            

            using (student_council_kitEntities db = new student_council_kitEntities())
            {
                var user = db.users.ToList().FirstOrDefault(x => (x.login == login) && (x.password == hash));
                if (user == null)
                {
                    user = student_council_kitEntities.GetContext().users.Where(x => x.login == login).FirstOrDefault();
                    if (user != null)
                    {
                        MessageBox.Show("Введен неверный пароль!");
                        var enter_date = DateTime.Now;
                        Manipulation_BD.AddEnter(login, enter_date, 2);
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден!");
                        var enter_date = DateTime.Now;
                        Manipulation_BD.AddEnter(login, enter_date, 2);
                    }
                    return false;

                }
                else
                {
                    var enter_date = DateTime.Now;
                    Manipulation_BD.AddEnter(login, enter_date, 1);
                    return true;
                }
            }
        }

        public static bool SignUp(string name, string surname, string patronymic, string name_faculty, int num_group, string email, string login, string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed sha256 = new SHA256Managed();
            byte[] Hash = sha256.ComputeHash(bytes);
            var hash = Convert.ToBase64String(Hash);

            using (student_council_kitEntities db = new student_council_kitEntities())
            {
                var user = db.users.FirstOrDefault(x => x.login == login);
                if (user != null)
                {
                    MessageBox.Show("Невозможно создать нового пользователя, т.к такой уже зарегистрирован");
                    return false;
                }
                else
                {
                    int id_faculty = 0;
                    var id_faculty_name = student_council_kitEntities.GetContext().faculties.Where(x => x.name_faculty == name_faculty);
                    foreach(var id in id_faculty_name)
                    {
                        id_faculty = id.id_faculty;
                    }
                    Manipulation_BD.AddUser(name, surname, patronymic, id_faculty, num_group, email, login, hash);
                    return true;
                }
            }
        }
    }
}
