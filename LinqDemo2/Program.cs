namespace LinqDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> evens = (from n in numbers
                               where n % 2 == 0
                               select n).ToList();

            numbers.Add(10);


            // display
            foreach (var item in evens)
            {
                Console.WriteLine(item);
            }
        }
    }
}