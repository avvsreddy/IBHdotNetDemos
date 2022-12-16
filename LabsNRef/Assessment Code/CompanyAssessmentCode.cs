namespace LogeshBhuvaneswaran_OO.EX.John_OO
{
    internal class Program
    {
        static void MainOld(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }

    public class Employee : Person
    {
        public long EmpId { get; set; }
        public float Basic { get; set; }
        public int Expreience { get; set; }

        public float GetSalary()
        {
            float salary = Basic + SalaryCalculator.CalculateAllowance(Expreience, Basic);
            return salary;
        }
    }

    public class Customer : Person
    {
        public long CustomerId { get; set; }
        public string EmailId { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
        public DateOnly IncorporationDate { get; set; }
        private List<Branch> Others { get; set; }
        private Branch Corporate { get; set; }
        private Branch Registered { get; set; }

        public List<Customer> customers { get; set; }
        public List<Employee> employees { get; set; }

        public int GetTotalCustomers()
        {
            int totalCustomers = 0;
            foreach (Customer customer in customers)
            {
                totalCustomers++;
            }
            return totalCustomers;
        }
        public float GetTotalSalaryPayout()
        {
            float totalSalaryPayout = 0;
            foreach (Employee employee in employees)
            {
                totalSalaryPayout += employee.GetSalary();
            }
            return totalSalaryPayout;
        }
        public Employee GetEmployeeByEmpId(long Id)
        {
            foreach (Employee employee in employees)
            {
                if (employee.EmpId == Id)
                {
                    return employee;
                }
            }
            throw new Exception(" Employee DoesNot Exist...");
        }
        public List<Employee> GetExperiencedEmployees(int YearOfExperience)
        {
            List<Employee> ExperiencedEmployees = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Expreience > YearOfExperience)
                {
                    ExperiencedEmployees.Add(employee);
                }
            }
            return ExperiencedEmployees;
        }
        public Dictionary<int, List<Employee>> GetEmployeesGroupedByAge()
        {
            Dictionary<int, List<Employee>> EmployeesGroupedByAge = new Dictionary<int, List<Employee>>();
            foreach (Employee employee in employees)
            {
                List<Employee> employees = new List<Employee>();
                foreach (Employee employee1 in employees)
                {
                    if ((employee.EmpId != employee1.EmpId) && (employee.Age == employee1.Age))
                    {
                        employees.Add(employee1);
                    }
                }
                EmployeesGroupedByAge.Add(employee.Age, employees);
            }
            return EmployeesGroupedByAge;
        }
    }

    public class Branch
    {
        public string Name { get; set; }
    }

    public class SalaryCalculator
    {
        private SalaryCalculator()
        {

        }
        public static float CalculateAllowance(int experience, float basic)
        {
            if (experience <= 2)
            {
                return (float)(basic * 0.3);
            }
            else if (experience <= 4)
            {
                return (float)(basic * 0.4);
            }
            else if (experience <= 6)
            {
                return (float)(basic * 0.5);
            }
            else
            {
                return (float)(basic * 0.65);
            }
        }
    }

}