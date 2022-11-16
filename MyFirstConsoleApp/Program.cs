namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) // SRP - PL
        {
            // Accept two ints and find the max and display

            int fno;
            int sno;
            int max;
            Console.WriteLine("Enter First Number:");
            fno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            sno = int.Parse(Console.ReadLine());

            max = SimpleMathClassLibrary.SimpleMath.FindMax(fno, sno);
            Console.WriteLine(max);
            Console.WriteLine($"The maximum of {fno} and {sno} is {max}");



        }


    }


}


