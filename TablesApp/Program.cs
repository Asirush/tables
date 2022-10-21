using System;
using Tables.dll;

namespace TablesApp
{
    public class Program
    {
    

        static void Main(string[] args)
        {
            Room MeetUp = new();
            MeetUp.AddJob("developer");
            MeetUp.AddJob("accountant");

            MeetUp.CreateTables(3, 2);
            MeetUp.AddUser("Asir", "Abdukhalikov", "developer");
            MeetUp.GetRoomUsersData();
        }
    }
}
