public class Store
{
    private List<StoreItem> _items = new List<StoreItem>();
    private List<StoreItem> _purchasedItems = new List<StoreItem>();

    public Store()
    {
        _items.Add(new StoreItem("Temple Recommend Holder", 50, "Keep yourself temple-focused and worthy."));
        _items.Add(new StoreItem("CTR Ring Upgrade", 100, "Choose the Right — earn this token of good choices."));
        _items.Add(new StoreItem("Scripture Hero Badge", 75, "Become mighty in the scriptures."));
        _items.Add(new StoreItem("Missionary Plaque", 150, "Symbol of sharing your light with others."));
        _items.Add(new StoreItem("Ministering Star", 80, "Recognizes consistent service and kindness."));
        _items.Add(new StoreItem("Family History Token", 60, "Turn your heart to your ancestors."));
        _items.Add(new StoreItem("Faith Shield", 120, "Symbol of strong faith and perseverance."));
        _items.Add(new StoreItem("Scripture Power Scroll", 90, "Feast upon the words of Christ."));
        _items.Add(new StoreItem("Zion Builder Badge", 200, "Build Zion through your daily efforts."));
        _items.Add(new StoreItem("Celestial Trophy", 300, "The ultimate recognition of spiritual progress."));
    }

    public void DisplayItems()
    {
        Console.WriteLine("Points Store — LDS Rewards");
        for (int i = 0; i < _items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_items[i]}");
        }
    }

    public void DisplayPurchased()
    {
        Console.WriteLine("Purchased Items:");
        if (_purchasedItems.Count == 0)
        {
            Console.WriteLine("You haven’t purchased anything yet!");
            return;
        }

        foreach (var item in _purchasedItems)
        {
            Console.WriteLine($"- {item.Name}");
        }
    }

    public int Purchase(int index, int userPoints)
    {
        if (index < 1 || index > _items.Count)
        {
            Console.WriteLine("Invalid selection.");
            return 0;
        }

        var item = _items[index - 1];
        if (userPoints >= item.Cost)
        {
            Console.WriteLine($"You purchased {item.Name}!");
            _purchasedItems.Add(item);
            return item.Cost; // subtract from score
        }
        else
        {
            Console.WriteLine($"Not enough points! {item.Cost - userPoints} more needed.");
            return 0;
        }
    }
}