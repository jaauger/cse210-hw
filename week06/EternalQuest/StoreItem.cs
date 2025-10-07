public class StoreItem
{ 
    public string Name { get; }
    public int Cost { get; }
    public string Description { get; }

    public StoreItem(string name, int cost, string description)
    {
        Name = name;
        Cost = cost;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Name} - {Cost} pts\n   {Description}";
    }
    
}