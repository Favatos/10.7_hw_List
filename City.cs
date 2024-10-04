namespace _10._7_hw_List;

public class City
{
    public Street[] streets;
    public City(string name, Street[] streets)
    {
        Name = name;
        this.streets = streets;
    }

    public string Name {  get; set; }

}
