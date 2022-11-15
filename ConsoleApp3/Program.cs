namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // select all evens into new array
            int[] evens = new int[numbers.Length];
            int index = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    evens[index++] = n;
                }
            }

            foreach (int item in evens)
            {
                //Console.WriteLine(item);
            }
            // table : numbers
            // column : number
            //sql: select number from numbers where number mod 2 = 0
            var evenNumbers = from n in numbers where n % 2 == 0 select n;
            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            int sum = numbers.Sum();
            int max = numbers.Max();
            double avg = numbers.Average();
            int min = numbers.Min();
            Array.Sort(numbers);


        }
    }
}