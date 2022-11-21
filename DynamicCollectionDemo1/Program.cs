namespace DynamicCollectionDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept n number of ints and display

            DynamicArray<int> a = new DynamicArray<int>();



            List<double> dArray = new List<double>();

            //DynamicArray<double> dArray = new DynamicArray<double>();
            dArray.Add(10.6);
            dArray.Add(20);
            dArray.Add(343.34);
            dArray.Add(2343.32);
            //dArray.Add(10);
            //dArray.Add(20);
            //dArray.Add(30.7);
            //dArray.Add(40);
            //dArray.Add(10);
            //dArray.Add(20);
            //dArray.Add(30);
            //dArray.Add(40);
            //dArray.Add(10);
            //dArray.Add(20);
            //dArray.Add(30);
            //dArray.Add(40);

            for (int i = 0; i < dArray.Count; i++)
            {
                Console.WriteLine(dArray[i]);
            }
        }
    }

    class DynamicArray<T>
    {
        private T[] storage = new T[4];
        private int index = 0;
        public void Add(T v)
        {
            if (index >= storage.Length) // full
            {

                Array.Resize(ref storage, storage.Length * 2);
                storage[index++] = v;
            }
            else
            {
                storage[index++] = v;
            }
        }

        public T Get(int i)
        {
            return storage[i];
        }

        public int Count
        {
            get { return index; }
        }
    }




}