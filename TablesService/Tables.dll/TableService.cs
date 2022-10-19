using LiteDB;
using System;
using System.Collections.Generic;

namespace Tables.dll;

public class TableService
{
    public string Path { get; set; }
    public int TableCount {get;set;}
    public List<Table> TableList = new List<Table>();

    public TableService(string path, int tableCount, int placesCount)
    {
        TableCount = tableCount;
        Path = path;

        for(int i = 1; i <= TableCount; i++){
            TableList.Add(new Table(i));
            TableList[i].SetPlacesCount(placesCount);   
        }
    }
    public bool AddGuest(Guest a){
        try{
            using (var db = new LiteDatabase(Path))
            {
                var Guests = db.GetCollection<Guest>("Guest");
                Guests.Insert(a);
                return true;
            }
        }
        catch(Exception ex){
            Console.WriteLine(ex);
            return false;
        }
    }
}
