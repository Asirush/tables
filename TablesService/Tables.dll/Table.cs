namespace Tables.dll;
public class Table
{
    public int TableId {set;get;}
    public int PlacesCount{set;get;}
    public List<Place> TablePlaces = new List<Place>();

    public Table(int count)
    {
        TableId = count;
    }
    public void SetPlacesCount(int count){
        PlacesCount = count;
    }
    public bool AddPlace(Place a){
        try{
            if(TablePlaces.Count <= PlacesCount){
                TablePlaces.Add(a);
                return true;
            }
            else{
                Console.WriteLine("Table is bussy");
                return false;
            }
            
        }
        catch(Exception ex){
            Console.WriteLine(ex);
            return false;
        }
    }
    public List<Guest> GetGuests(){
        List<Guest> tmp = new List<Guest>();
        foreach (var place in TablePlaces)
        {
            tmp.Add(place.GetGuest());
        }
        return tmp;
    }
}
