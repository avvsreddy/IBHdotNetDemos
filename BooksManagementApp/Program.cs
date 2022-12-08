using EmployeeManagementApp.DataAccess;
using EmployeeManagementApp.Entities;
using EmployeeManagementApp.Exceptions;

namespace BooksManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter emp id to search: ");
            int id = int.Parse(Console.ReadLine());
            IEmployeeRepository repo = new EmployeeRepository();
            Employee emp = repo.GetEmployee(id);
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Salary);

        }

        private static void update()
        {
            Employee emp = new Employee();
            Console.Write("Enter Emp id to update :");
            emp.EmpID = int.Parse(Console.ReadLine());
            Console.Write("Enter new name: ");
            emp.Name = Console.ReadLine();
            Console.Write("Enter new salary: ");
            emp.Salary = int.Parse(Console.ReadLine());
            IEmployeeRepository repo = new EmployeeRepository();
            repo.Update(emp);
            Console.WriteLine("Updated....");
        }

        private static void Delete()
        {
            Console.Write("Enter empid to delete: ");
            int empid = int.Parse(Console.ReadLine());
            IEmployeeRepository repo = new EmployeeRepository();
            try
            {
                repo.Delete(empid);
                Console.WriteLine("Emp deleted...");
            }
            catch (EmployeeNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SaveEmp()
        {
            // Store emp details into db
            Employee emp = new Employee();
            Console.Write("Enter Emp name: ");
            emp.Name = Console.ReadLine();
            Console.Write("Enter salary: ");
            emp.Salary = int.Parse(Console.ReadLine());

            IEmployeeRepository repo = new EmployeeRepository();
            repo.Save(emp);
            Console.WriteLine("Emp saved...");
        }
    }
}