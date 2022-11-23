namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                numbers.Add(int.Parse(input));
            }
            Console.WriteLine("thanks");
            Console.WriteLine($"The sum is : {numbers.Sum()}");
        }
    }
}