namespace Tables.dll;
public class Room
{
    int UserCounter = 0;
    public int RoomId{set;get;}
    public List<Table> Tables = new List<Table>();

    public void CreateTables(int tablesCount, int tablesSize){
        for(int i=1; i<=tablesCount; i++)
        {
            Tables.Add(new Table(i, tablesSize));
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

    public bool AddUser(string name, string surname, string job){
        try{
            foreach (var item in Tables)
            {
                if(item.IsTableFull() == false){
                    item.AddNewUser(name, surname, job);
                    return true;
                }
                else{
                    Console.WriteLine("error: no free tables");
                    return false;
                }
            }
        }
        catch(Exception ex){
            Console.WriteLine(ex);
            return false;
        }
    }
}
