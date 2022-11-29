class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 4, 5 };
        Dictionary<int, int> counts = new Dictionary<int, int>();
        numbers.Sort();
        foreach (var item in numbers)
        {
            if (counts.ContainsKey(item))
                counts[item]++;
            else
                counts[item] = 1;
        }

        Console.WriteLine("duplicates");
        foreach (var item in counts)
        {
            Console.WriteLine($"{item.Key} found {item.Value}");
        }
    }
}