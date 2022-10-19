namespace Tables.dll;
public class Guest
{

    public int GuestId{set;get;}
    public string Name{set;get;}
    public string Surname{set;get;}
    public string JobTitle{set;get;}

    public Guest()
    {
        GuestId = 0;
        Name = "";
        Surname = "";
        JobTitle = "";
    }
    public Guest(string name, string surname, string jobtitle)
    {
        Name = name; Surname = surname; JobTitle = jobtitle;   
    }
    public bool SetGuestData(string name, string surname, string jobtitle){
        try{
                Name = name;
                Surname = surname;
                JobTitle = jobtitle;
                return true;
        }
        catch(Exception ex){
            Console.WriteLine(ex);
            return false;
        }
    }
}
