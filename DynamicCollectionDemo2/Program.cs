namespace DynamicCollectionDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            List<int> list = new List<int>();
            list.Add(10);
            int a = list[0];

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            a = stack.Pop();//read and remove
            a = stack.Peek();//read

            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            a = q.Peek();
            a = q.Dequeue();




        }
    }
}