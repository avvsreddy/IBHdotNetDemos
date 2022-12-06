namespace Linq2ObjectsDemo
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //1.  get all items belongs to brand called apple

            var result1 = from r in GetItems()
                          where r.Brand == "Dell"
                          select r;

            // 2. get all items price > 80k

            var result2 = from r in GetItems()
                          where r.Price >= 80000
                          select r;
            // display


            // get only names

            var result3 = from r in GetItems()
                          select r.Name;

            // get names and price of all products

            var r4 = from r in GetItems()
                     select new { ItemName = r.Name, ItemRate = r.Price };

            // get sum of all rates

            var total = (from r in GetItems()
                         where r.Brand == "Apple"
                         select r.Price).Sum();

            // get item name and catagory name only

            var result5 = from r in GetItems()
                          select new { ItemName = r.Name, CatagoryName = r.Catagory.Name };

            var result6 = from r in GetItems()
                          group r by r.Catagory.Name into g

                          select new { Catagory = g.Key, Count = g.Count() };

            var r6 = (from r in result6
                      where r.Count == (from rr in result6 select rr.Count).Max()
                      select r.Catagory).FirstOrDefault();
            Console.WriteLine(r6);
            foreach (var item in result6)
            {
                Console.WriteLine($"{item.Catagory}\t{item.Count}");
            }

        }

        public static List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            Catagory c1 = new Catagory { CatagoryID = 111, Name = "Mobiles" };
            Catagory c2 = new Catagory { CatagoryID = 222, Name = "Laptops" };

            Item i1 = new Item { ItemID = 100, Name = "I Phone X", Brand = "Apple", Catagory = c1, Price = 75000 };
            Item i2 = new Item { ItemID = 101, Name = "I Phone XI ", Brand = "Apple", Catagory = c1, Price = 79000 };
            Item i3 = new Item { ItemID = 102, Name = "I Phone XII", Brand = "Apple", Catagory = c1, Price = 85000 };

            Item i4 = new Item { ItemID = 103, Name = "Dell XPS", Brand = "Dell", Catagory = c2, Price = 75000 };

            items.Add(i1);
            items.Add(i2);
            items.Add(i3);
            items.Add(i4);
            return items;
        }
    }

    //class ItemNamePrice
    //{
    //    public string ItemName { get; set; }
    //    public int ItemRate { get; set; }
    //}

    class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }
        public string Brand { get; set; }

        public Catagory Catagory { get; set; }
    }

    class Catagory
    {
        public int CatagoryID { get; set; }
        public string Name { get; set; }
    }
}