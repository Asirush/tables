using Beta2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Room MeetUp = new Room();
            //MeetUp.AddJob("developer");
            //MeetUp.AddJob("accountant");

            //MeetUp.CreateTables(3, 2);
            MeetUp.AddUser("Asir", "Abdukhalikov", "developer");
            MeetUp.GetRoomUsersData();
        }
    }
}
