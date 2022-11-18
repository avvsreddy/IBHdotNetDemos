namespace OODemo1
{
    internal class Program : Object
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
            //shapes.Add(new Shape());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());
            foreach (var item in shapes)
            {
                Paint(item);
            }

        }

        static void Paint(Shape s)
        {
            s.Draw();
        }
    }

    interface IShape
    {
        int H { get; set; }
        int W { get; set; }



        void Draw();


        double CalculateArea();

    } // OCP

    class Circle
    {

    }

    class Rectangle : IShape // IS-A -> Generalaization
    {
        public int H { get; set; }
        public int W { get; set; }
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
        public double CalculateArea()
        {
            return H * W;
        }

    }

    class Triangle : IShape
    {

        public int H { get; set; }
        public int W { get; set; }
        public void Draw()
        {
            Console.WriteLine("Drawing Triangle...");
        }
        public double CalculateArea() // Hiding - 
        {
            Console.WriteLine("Calculating Triangle Area");
            return (H * W) * 0.5;
        }
    }



    class Calculator
    {
        // overloading - static polymorphism

        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }


    interface IA
    {

    }
    interface IB
    {

    }

    class C : IB, IA
    {

    }
}