using student_council.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using student_council.Models;
using System.Net.Mail;
using System.Net;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;


namespace student_council.Models
{
    public class Enroll_and_Other
    {
        public static bool Enroll(List<events> selectedEvent, users currentUser)
        {
            int id_user = Convert.ToInt32(currentUser.id_user);
            int id_event = 0;
            
            foreach (var item in selectedEvent)
            {
                id_event = Convert.ToInt32(item.id_event);
            }
            var eevent = student_council_kitEntities.GetContext().events.Where(x => x.id_event == id_event).FirstOrDefault();
            events_participant eventsParticipant = new events_participant()
            {
                id_user = id_user,
                id_event = id_event
            };
            var checkEnroll = student_council_kitEntities.GetContext().events_participant.FirstOrDefault(x => x.id_event == id_event && x.id_user == id_user);
            int status = eevent.id_status;
            if (status == 3)
            {

                if (checkEnroll == null)
                {
                    int num_place = eevent.num_place;
                    if (num_place != 0)
                    {
                        try
                        {
                            student_council_kitEntities.GetContext().events_participant.Add(eventsParticipant);
                            num_place -= 1;
                            eevent.num_place = num_place;
                            student_council_kitEntities.GetContext().Entry(eevent).State = System.Data.Entity.EntityState.Modified;
                            student_council_kitEntities.GetContext().SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно записаться! Нет свободных мест.");
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Невозможно записаться! Мероприятие завершилось.");
                return false;
            }
        }

        public static bool AddRehearsal(List<users> selected_user, DateTime date_reh)
        {
            int id_user = 0;
            if (date_reh < DateTime.Now)
            {
                MessageBox.Show("Неверно выбрана дата проведения мероприятия!");
                MessageBox.Show("Дата начала не может находится в прошедших датах!");
                return false;
            }
            else
            {
                if (date_reh != null)
                {
                    rehearsals rehearsals = new rehearsals()
                    {
                        date = date_reh,
                        id_creater = AutorizationWindow.user.id_user
                    };
                    student_council_kitEntities.GetContext().rehearsals.Add(rehearsals);
                    student_council_kitEntities.GetContext().SaveChanges();
                    if (selected_user != null)
                    {
                        foreach (var item in selected_user)
                        {
                            id_user = item.id_user;
                            rehearsals_participant rehearsals_Participant = new rehearsals_participant()
                            {
                                id_user = id_user,
                                id_rehearsal = rehearsals.id_rehearsal,
                            };

                            student_council_kitEntities.GetContext().rehearsals_participant.Add(rehearsals_Participant);
                            var user = student_council_kitEntities.GetContext().users.Where(x => x.id_user == id_user).ToList();
                            foreach (var i in user)
                            {
                                SendMail(i.email, rehearsals.date, i.name, i.patronymic);
                            }
                        }
                        student_council_kitEntities.GetContext().SaveChanges();
                        MessageBox.Show("Репетиция успешно создана!");

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали участников репетиции!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали дату репетиции!");
                    return false;
                }
            }
            
        }

        public static bool Add_Post( string selected_post, int id_user)
        {
            int? id_post = 0;
            var post = student_council_kitEntities.GetContext().posts.Where(x => x.name_post == selected_post);
            foreach (var item in post)
            {
                id_post = item.id_post;
            }
            var stud_council = student_council_kitEntities.GetContext().student_council.FirstOrDefault(x => x.id_user == id_user);
            stud_council.id_post = id_post;
            student_council_kitEntities.GetContext().SaveChanges();
            return true;
        }

        public static void SendMail(string email, DateTime date, string name, string patronymic)
        {
            try
            {
                MailAddress from = new MailAddress("tantk2003@mail.ru");
                MailAddress to = new MailAddress(email);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Тест";
                m.Body = $"<h2>Доброго времени суток.{name} {patronymic}, у вас репетиция {date}. Не забудьте! </h2>";
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                smtp.Credentials = new NetworkCredential("tantk2003@mail.ru", "sZSauysS9kmd9zWtiXMr");
                smtp.EnableSsl = true;
                smtp.SendMailAsync(m);
                MessageBox.Show("Письмо успешно отправлено");
            }
            catch
            {
                MessageBox.Show("Почта введена некорректно");
            }
        }

        public static void SendCode(string email, int code)
        {
            try
            {
                MailAddress from = new MailAddress("tantk2003@mail.ru");
                MailAddress to = new MailAddress(email);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Код восстановления";
                m.Body = $"<h2>Код для восстановления пароля: {code} </h2>";
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                smtp.Credentials = new NetworkCredential("tantk2003@mail.ru", "sZSauysS9kmd9zWtiXMr");
                smtp.EnableSsl = true;
                smtp.SendMailAsync(m);
                MessageBox.Show("Письмо успешно отправлено");
            }
            catch
            {
                MessageBox.Show("Почта введена некорректно");
            }
        }
    }
}
