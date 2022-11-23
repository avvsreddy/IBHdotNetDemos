namespace LambdaDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Func<int, bool> filter = new Func<int, bool>(IsEven);
            int sum = numbers.Where(filter).Sum();

            sum = numbers.Where(IsEven).Sum();

            sum = numbers.Where(x => x % 2 == 0).Sum();
            sum = (from n in numbers
                   where n % 2 == 0
                   select n).Sum();

            int evenSum = 0;

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                    evenSum += item;
            }

            Console.WriteLine(evenSum);

        }

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}