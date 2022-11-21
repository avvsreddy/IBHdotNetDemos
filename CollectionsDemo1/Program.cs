namespace CollectionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fixed Collection

            // store and display 10 ints
            int a = 10;
            int[] numbers = new int[a];
            numbers[0] = 10;
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };

            int[] array3 = { 1, 23, 5, 3, 5, 6 };

            int[,] twod = new int[3, 6];
            twod[0, 0] = 10;

            // jogged arrays
            int[][] jarray = new int[3][];
            jarray[0] = new int[3];
            jarray[1] = new int[5];
            jarray[2] = new int[2];


            int[] array2 = new int[] { 1, 22, 5, 34, 5, 17, 8 };
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Array.Sort(array2);
            Array.Reverse(array2);
            Console.WriteLine("-------");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(array2.Sum());
            Console.WriteLine(array2.Max());
            Console.WriteLine(array2.Min());
            Console.WriteLine(array2.Average());
            Console.WriteLine(array2.Count());


        }
    }
}