namespace Tables.dll;
public class Table
{
    public int TableId {set;get;}
    public int GuestCount{set;get;}
    public List<Guest> GuestList = new List<Guest>();

    public List<Guest> GetGuests(){
        return GuestList;
    }

    public int GetTableId(){
        return TableId;
    }
}
