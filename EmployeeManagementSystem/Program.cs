namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product();
            //p1.ProductId = 111;
            //p1.Name = "I Phone 14 Plus";
            //p1.Rate = 125000;
            //p1.Catagory = "Mobiles";
            //p1.Brand = "Apple";


            // Object Initialization Syntax

            var p2 = new { ProductId = 222, Name = "I Phone" };


            var p3 = new { Name = "I Phone" };

            var p4 = new { ProductId = 134, Name = "name", Rate = 563464 };



        }
    }

    abstract class Calculator
    {
        public int Sum(int fno, int sno) { return fno + sno; }
        public abstract int Multiply(int fno, int sno);
    }

    class SuperCalculator : Calculator
    {
        public override int Multiply(int fno, int sno)
        {
            return fno * sno;
        }

        public int Sum(int fno, int sno)
        {
            return fno + sno;
        }
    }
    class Person
    {

    }

    class Employee : Person
    {
        //private int empid, eid;
        private int backingfields23423423423423;
        string name;
        double salary;


        public int EmpId // Property
        {
            set;//{ this.empid = value; }
            get; //{ return empid; }
        }
        //public void SetEmpId(int empid)
        //{
        //    this.empid = empid;
        //}
        //public int GetEmpId()
        //{
        //    return empid;
        //}
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
    }


    //class Product
    //{

    //    public int ProductId { get; set; }
    //    public string Name { get; set; }
    //    public double Rate { get; set; }
    //    public string Catagory { get; set; }
    //    public string Brand { get; set; }

    //}
}