namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linq to Objects
            List<int> numbers = new List<int> { 14, 32, 32, 24, 45, 56, 17, 88, 19 };
            // table : numbers
            // col : number
            // sql: select number from numbers where number mod 2 = 0
            // Linq to Object

            // LINQ Expressions
            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              orderby n descending
                              select n;
            // Extension Methods
            //Func<int, bool> FilterDelegate = new Func<int, bool>(IsEven);
            var even2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

            // get all evens into new collection
            //List<int> evens = new List<int>();
            //foreach (var item in numbers)
            //{
            //    if (item % 2 == 0)
            //        evens.Add(item);
            //}

            foreach (var item in even2)
            {
                Console.WriteLine(item);
            }

        }
        //public static bool IsEven(int n)
        //{
        //    return n % 2 == 0;
        //}
    }
}