using LiteDB;

namespace Tables.dll;

public static class TablesService
{
    public static void AddExistingUser(User a){
        
    }

    public static ReturnResult AddNewUser(string name, string surname, string job, int tableId){
        try{
            using(var db = new LiteDatabase("")){
                var Users = db.GetCollection<User>("User");
                if(Users.Insert(new User(name, surname, job, tableId))!=0){
                    return new ReturnResult(true, "ok");
                }
                else{
                    return new ReturnResult(false, "bad");
                }
            }
        }
        catch(Exception ex){
            return new ReturnResult(false, ex.Message);
        }
    }

    public static void GetUserData(int id){
        foreach (var item in Users)
        {
            if(item.UserId == id){
                item.GetUserData();
            }
            else{
                Console.WriteLine("error: no such user");
            }
        }
    }

    
   
}
