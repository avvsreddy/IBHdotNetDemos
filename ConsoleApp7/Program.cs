using System.Diagnostics;

namespace ParallelConsoleApp2
{
    class Program
    {
        static int ROWS = 15000;
        static int COL = 15000;

        static void Main(string[] args)
        {

            int[,] matrix1 = new int[ROWS, COL];
            int[,] matrix2 = new int[ROWS, COL];
            Console.WriteLine($"Initializing Matrix...{ROWS} X {COL}");
            InitializeMatrix(matrix1);
            InitializeMatrix(matrix2);
            Console.WriteLine("Done");
            Console.WriteLine("Multiplying");
            Stopwatch sw = Stopwatch.StartNew();
            var result = MultiplyMatrix(matrix1, matrix2);
            Console.WriteLine("done");
            Console.WriteLine($"Multipling took {sw.ElapsedMilliseconds} ms");


        }

        static void InitializeMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < ROWS; i++)
            {
                for (int x = 0; x < COL; x++)
                {
                    matrix[i, x] = rnd.Next(1, 99);
                }
            }
        }
        static int[,] MultiplyMatrix(int[,] m1, int[,] m2)
        {
            //TODO: Improve the performance 

            int[,] result = new int[ROWS, COL];
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COL; c++)
                {
                    result[r, c] = m1[r, c] * m2[r, c];
                }
            }
            return result;
        }
    }
}
