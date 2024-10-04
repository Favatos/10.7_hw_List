namespace _10._7_hw_List;

public class Street
{
    public string Name { get; set; }
    public House[] homes;

    public Street(string name, House[] homes)
    {
        Name = name;
        this.homes = homes;
    }
}
