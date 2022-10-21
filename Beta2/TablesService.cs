using System;

namespace Beta2
{
    public class TablesService
    {
        private EntityDbContext db = new EntityDbContext();

        public ReturnResult AddUser(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return new ReturnResult(true, "Пользователь успешно зарегистрирован и прикреплен к столу");
            }
            catch
            {
                return new ReturnResult(false, "При регистрации пользователя вощникла ошибка, обратитесь к администратору");
            }
        }

        public ReturnResult AddJobTitle(JobTitle title)
        {
            db.JobTitles.Add(title);
            db.SaveChanges();
            return new ReturnResult(true, "Пользователь успешно зарегистрирован и прикреплен к столу");
        }

        public static void GetUserData(Desc tabl, int id)
        {
            foreach (var item in tabl.Users)
            {
                if (item.UserId == id)
                {
                    item.GetUserData();
                }
                else
                {
                    Console.WriteLine("error: no such user");
                }
            }
        }
    }
}

