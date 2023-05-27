using student_council;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace student_council.Controllers
{
    public class Manipulation_BD
    {
        public static void AddUser(string name, string surname, string patronymic, int id_faculty, int num_group, string email, string login, string hash)
        {
            using (student_council_kitEntities db = new student_council_kitEntities())
            {
                    db.users.Add(new users()
                    {
                        name = name,
                        surname = surname,
                        patronymic = patronymic,
                        id_faculty = id_faculty,
                        num_group = num_group,
                        email = email,
                        login = login,
                        password = hash,
                        role = "Студент"
                    });
                    db.SaveChanges();
             
            }
        }


        public static bool AddEvent(int id_direction, string name, string description, DateTime date, int id_destiny, int num_place)
        {
            using (student_council_kitEntities db = new student_council_kitEntities())
            {
                if (date <= DateTime.Now)
                {
                    MessageBox.Show("Неверно выбрана дата проведения мероприятия!");
                    MessageBox.Show("Дата начала не может находится в прошедших датах!");
                    return false;
                }
                else
                {
                    db.events.Add(new events()
                    {
                        id_direction = id_direction,
                        name = name,
                        description = description,
                        date = date,
                        id_destiny = id_destiny,
                        num_place = num_place,
                        id_status = 3
                    });
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public static bool AddEnter(string login, DateTime enter_date, int id_status)
        {
            using (student_council_kitEntities db = new student_council_kitEntities())
            {
                db.enter_history.Add(new enter_history()
                {
                    login = login,
                    enter_date = enter_date,
                    id_status = id_status,
                });

                db.SaveChanges();
                return true;
            }
        }

        public static bool DeleteRecord(List<events_stud_View> selectedEvent, users currentUser)
        {
            int id_user = Convert.ToInt32(currentUser.id_user);
            int id_event = 0;
           
            foreach (var item in selectedEvent)
            {
                id_event = Convert.ToInt32(item.id_event);
            } 
            var eevent = student_council_kitEntities.GetContext().events.Where(x => x.id_event == id_event).FirstOrDefault();
            int num_place = eevent.num_place;
            events_participant events_Participant = new events_participant()
            {
                id_user = id_user,
                id_event = id_event
            };
            var del = student_council_kitEntities.GetContext().events_participant.FirstOrDefault(x => (x.id_user == id_user && x.id_event == id_event));
            student_council_kitEntities.GetContext().events_participant.Remove(del);
            num_place += 1;
            eevent.num_place = num_place;
            student_council_kitEntities.GetContext().SaveChanges();
            return true;
        }

        public static bool AddDirectionParticipant(List<directions> selectedDirection, users currentUser)
        {
            int id_user = Convert.ToInt32(currentUser.id_user);
            int id_direction = 0;
            foreach (var item in selectedDirection)
            {
                id_direction = Convert.ToInt32(item.id_direction);
            }
            direction_participant direction_Participant = new direction_participant()
            {
                id_direction = id_direction,
                id_user = id_user,
            };
            var checkRecord = student_council_kitEntities.GetContext().direction_participant.FirstOrDefault(x => x.id_direction == id_direction && x.id_user == id_user);
            if(checkRecord == null)
            {
                student_council_kitEntities.GetContext().direction_participant.Add(direction_Participant);
                student_council_kitEntities.GetContext().SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool ChangeUser(string name, string surname, string patronimic, faculties id_faculty, int num_group, string email, users user)
        {
            if (name == null || surname == null || patronimic == null || email == null || user == null || id_faculty == null || num_group == 0)
            {
                MessageBox.Show("Вы не ввели данные!");
                return false;

            }
            else
            {
                var user_change = student_council_kitEntities.GetContext().users.Where(x => x.id_user == user.id_user).FirstOrDefault();
                user_change.name = name;
                user_change.surname = surname;
                user_change.patronymic = patronimic;
                user_change.id_faculty = id_faculty.id_faculty;
                user_change.num_group = num_group;
                user_change.email = email;
                student_council_kitEntities.GetContext().SaveChanges();
                return true;
            }
        }

        public static bool ChangeEvent(int id_event, int id_direction, string name_event, string description, DateTime date, int id_destiny, int num_place)
        {
            var event_change = student_council_kitEntities.GetContext().events.Where(x => x.id_event == id_event).FirstOrDefault();
            if (id_direction == 0 || name_event == null || description == null || date == null || id_destiny == 0 || num_place == 0)
            {
                MessageBox.Show("Вы не ввели данные!");
                return false;
            }
            else
            {
                if(date > DateTime.Now)
                {
                    event_change.id_status = 3;
                    
                }
                event_change.id_direction = id_direction;
                event_change.name = name_event;
                event_change.description = description;
                event_change.date = date;
                event_change.id_destiny = id_destiny;
                event_change.num_place = num_place;
                student_council_kitEntities.GetContext().SaveChanges();
                MessageBox.Show("Мероприятие изменено!");
                return true;
            }
        }
    }
}
