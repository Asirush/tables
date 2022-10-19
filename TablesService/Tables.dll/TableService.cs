namespace Tables.dll;
public class TableService
{
    public string Path { get; set; }
    public int TableCount {get;set;}
    public List<Table> TableList = new List<Table>();

    public TableService(string Path, int TableCount)
    {
        this.Path = Path;
        this.TableCount = TableCount;
    }


}
