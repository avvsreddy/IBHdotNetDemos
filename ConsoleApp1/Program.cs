namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.X();
        }
    }

    class A
    {
        public void M()
        {
            Console.WriteLine("I am M in A");
        }
    }

    class B : A
    {
        public void M()
        {
            Console.WriteLine("I am M in  B");
        }
        public void X()
        {
            base.M();
        }
    }
}