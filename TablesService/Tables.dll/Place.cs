namespace Tables.dll;
public class Place
{
    public enum PlaceStat {empty, filled};

    public Guest GuestOnPlace {get;set;}
    public int PlaceId {get;set;}
    public PlaceStat status {get;set;}

    public Place()
    {
        GuestOnPlace = new Guest();
        status = PlaceStat.empty;
        PlaceId = 0;
    }

    public Place(int placeId, int tablesId)
    {
        PlaceId = placeId;
        GuestOnPlace = new Guest();
        status = PlaceStat.filled;
    }
    public Guest GetGuest (){
        return GuestOnPlace;
    }

    public void SetGuest(Table table, Guest guest){
        
    }
}
