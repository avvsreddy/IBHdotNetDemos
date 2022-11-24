namespace FileIODemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteFile();

            //ReadAll();

            // read line by line
            // read data from file
            StreamReader sr = new StreamReader("e://sample//test.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            sr.Close();



        }

        private static void ReadAll()
        {
            // read data from file
            StreamReader sr = new StreamReader("e://sample//test.txt");
            string allLines = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(allLines);
        }

        private static void WriteFile()
        {
            StreamWriter sw = null;
            try
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                // store the name into file
                sw = new StreamWriter("e://sample//test.txt", true);
                sw.WriteLine(name);
                // sdfsdfd
                //sdfsdfsdf
                //sdfsdfsdf
            }
            finally
            {
                sw.Close();
            }
        }
    }
}