namespace Tables.dll;
public class Room
{
    int UserCounter = 0;
    public int RoomId{set;get;}
    public List<Table> Tables = new List<Table>();

    public void CreateTables(int tablesCount, int tablesSize){
        using(var db = new LiteDatabase("")){
            for(int i=1; i<=tablesCount; i++)
            {
                var Tables = db.GetCollection<Table>("Table");
                Tables.Insert(new Table(tablesSize));
            }
            Tables = db.GetCollection<Table>("Table").FindAll().ToList();
        }
    }

    public void CreateCustomTable(int tablesSize){
        Tables.Add(new Table(tablesSize));
        int tmp = Tables.Count();
        Tables[tmp].TableId = tmp;
    }

    public void DeleteTable(int tableId){
        foreach (var item in Tables)
        {
            if(item.TableId == tableId){
                Tables.Remove(item);
            }
        }
    }

    public void GetRoomUsersData(){
        foreach (var item in Tables)
        {
            item.GetUsersData();
        }
    }

    public int CountUsersInRoom(){
        int result = 0;
        foreach (var item in Tables)
        {
            result += item.CountUsers();
        }
        return result;
    }

    public ReturnResult AddUser(string name, string surname, string job){
        ReturnResult result = new ReturnResult();
        try{
            if(Tables.Count(c=>!c.IsTableFull())>0)
            {
                while(result.BoolResult == false)
                {
                Random rnd = new Random();
                if(Tables.Count(c=>!c.IsTableFull())>0){
                    result.BoolResult = false;
                    result.Message = "no free tables";
                    break;
                }
                Table tmp = Tables.ElementAt(rnd.Next(0,Tables.Count()));
                
                if(tmp.IsTableFull() == false){
                    result = TablesService.AddNewUser(name, surname, job);
                    break;
                }
                }
            }
           
        }
        catch(Exception ex){
            Console.WriteLine(ex);
            result.BoolResult = false;
            result.Message = "no free tables";
        }
        return result;
    }
}
