
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beta2
{
    public class Room
    {
        private EntityDbContext db = new EntityDbContext();
        private TablesService ts = new TablesService();

        public void AddJob(string a)
        {

            var dd = db.JobTitles.ToList();



            db.JobTitles.Add(new JobTitle(a));
            db.SaveChanges();
        }

        public void CreateTables(int tablesCount, int tablesSize)
        {
            for (int i = 1; i <= tablesCount; i++)
            {
                db.Descs.Add(new Desc(tablesSize));
                db.SaveChanges();
            }
        }

        public void CreateCustomTable(int tablesSize)
        {
            //    Tables.Add(new Desc(tablesSize));
            //    int tmp = Tables.Count();
            //    Tables[tmp].DescId = tmp;
        }

        public void DeleteTable(int descId)
        {
            var desc = db.Descs.Find(descId);
            db.Descs.Remove(desc);
            db.SaveChanges();
        }

        public void GetRoomUsersData()
        {
            foreach (Desc desc in db.Descs)
            {
                foreach (User user in desc.Users)
                {
                    Console.WriteLine(user.GetUserData());
                }
            }
        }

        public int CountUsersInRoom()
        {
            int result = db.Descs.Sum(s => s.CountUsers());

            return result;
        }

        public ReturnResult AddUser(string name, string surname, string job)
        {
            ReturnResult result = new ReturnResult();
            Random rnd = new Random();
            try
            {
                var data = db.Descs.Include("Users").ToList();

                if (db.Descs.ToList().Count(c => c.IsTableFull() == false) > 0)
                {
                    while (result.BoolResult == false)
                    {
                        if (db.Descs.Count(c => c.IsTableFull() == false) < 0)
                        {
                            result.BoolResult = false;
                            result.Message = "??? ????????? ???? ?? ???????, ?????? ???????????? ??? ??? ???????";
                            break;
                        }

                        Desc tmp = db.Descs.ElementAt(rnd.Next(0, db.Descs.Count()));

                        if (tmp.IsTableFull() == false)
                        {
                            result = ts.AddUser(new User(name, surname, tmp.DescId));
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.BoolResult = false;
                result.Message = "??? ????????? ???? ?? ???????, ?????? ???????????? ??? ??? ???????";
            }

            return result;
        }
    }
}