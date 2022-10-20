namespace Tables.dll;
public class User
{
    public int UserId{get;set;} = 0;
    public string UserName{set;get;} = string.Empty;
    public string UserSurname{set;get;} = string.Empty;
    public string UserJobTitle{set;get;} = string.Empty;
    public int TableId{set;get;}

public User(string username, string usersurname, string jobtitle, int tableId)
{
    UserName = username;
    UserSurname = usersurname;
    UserJobTitle = jobtitle;
    TableId = tableId;
}

    public string GetUserData(){
        return String.Format("#############\nid: {0}\nname: {1}\nsurname: {2}\njob_title: {3}", UserId, UserName, UserSurname, UserJobTitle);
    }
}
