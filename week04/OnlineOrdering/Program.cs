using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order();
        order1.SetAddress("123 Main Street", "Riverton", "Utah", "usa");
        order1.SetCustomer("Jane Doe");
        order1.SetProduct("gum", "gum01", 2.50, 2);
        order1.SetProduct("Dr Pepper", "DP01", 1.25, 6);
        order1.SetProduct("Chocolate Milk", "CMK01", 2.50, 2);

        orders.Add(order1);

        Order order2 = new Order();
        order2.SetAddress("456 Cornwall Street", "Kowloon", "Hong Kong", "SAR");
        order2.SetCustomer("Bobby Duke");
        order2.SetProduct("Cadmium Yellow", "CY01", 8.50, 1);
        order2.SetProduct("Vandyke Brown", "VDB01", 7.25, 2);
        order2.SetProduct("Titanium White", "TW01", 9.50, 2);

        orders.Add(order2);

        for (int i = 0; i < orders.Count; i++)
        {
            orders[i].DisplayPackingLabel();
            Console.WriteLine();
            orders[i].DisplayShippingLabel();
            Console.WriteLine("-------------------------------------------");
        }
    }
}