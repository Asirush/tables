namespace Tables.dll;
public class Table
{
    public int TableId{set;get;} = 0;
    public int MaxUsers{set;get;}
    public ICollection<User> Users = new List<User>();
public Table()
{
    
}
    public Table(int maxSize){
        MaxUsers = maxSize;
    }
    public Table(int id, int maxSize)
    {
        TableId = id;
        MaxUsers = maxSize;
    }

    public int CountUsers(){
        return Users.Count();
    }

    public bool IsTableFull(){
        if(Users.Count() < MaxUsers){
            return false;
        }
        else return true;
    }

    public void GetUsersData(){
        foreach (var item in Users)
        {
            item.GetUserData();
        }
    }
}
