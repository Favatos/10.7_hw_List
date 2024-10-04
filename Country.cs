namespace _10._7_hw_List;

public  class Country
{
    public Country(string name, City[] cities)
    {
        Name = name;
        this.cities = cities;
    }

    public string Name { get; set; }
    public City[] cities { get; set; }
}
