namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // store/accept emp details the display

            Employee e1 = new Employee();
            //e1.SetEmpId(111);
            e1.EmpId = 111;
            //Console.WriteLine(e1.GetEmpId());
            Console.WriteLine(e1.EmpId);

        }
    }

    class Employee
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
}