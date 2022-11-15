namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept 10 ints and find the sum

            int[] numbers = new int[10];

            // accept data
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter Number {i + 1} :");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            // find the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    sum += number;
            }

            Console.WriteLine($"The sum is {sum}");


            // table : numbers
            // column : number
            //sql: select number from numbers where number mod 2 = 0
        }
    }
}