using EmployeeManagementApp.Entities;
using EmployeeManagementApp.Exceptions;
using System.Data.SqlClient;

namespace EmployeeManagementApp.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="empid"></param>
        /// <exception cref="EmployeeNotFoundException"></exception>
        public void Delete(int empid)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EmpDatabase;Integrated Security=True";
            conn.Open();
            //Console.WriteLine("connected to db");

            // Step 2: prepare sql insert cmd
            //string sqlInsert = $"insert into employees values ('{empToSave.Name}',{empToSave.Salary})";
            string del = $"delete employees where empid ={empid}";
            // Step 3: exe sql cmd
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = del;
            cmd.Connection = conn;
            try
            {
                int count = cmd.ExecuteNonQuery();
                if (count == 0)
                {
                    throw new EmployeeNotFoundException("Emp id not found");
                }
            }
            // Step 4: close connection
            finally
            {
                conn.Close();
            }
        }

        public Employee GetEmployee(int empid)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EmpDatabase;Integrated Security=True";
            conn.Open();
            string select = $"select * from employees where empid = {empid}";
            // Step 3: exe sql cmd
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = select;
            cmd.Connection = conn;
            Employee emp = new Employee();
            try
            {
                //cmd.ExecuteNonQuery(); // insert/delete/update
                SqlDataReader reader = cmd.ExecuteReader(); // select

                reader.Read();
                emp.EmpID = (int)(reader[0]);
                emp.Name = reader[1].ToString();
                emp.Salary = int.Parse(reader[2].ToString());
            }
            // Step 4: close connection
            finally
            {
                conn.Close();
            }
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public void Save(Employee empToSave)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EmpDatabase;Integrated Security=True";
            conn.Open();
            //Console.WriteLine("connected to db");

            // Step 2: prepare sql insert cmd
            string sqlInsert = $"insert into employees values ('{empToSave.Name}',{empToSave.Salary})";
            // Step 3: exe sql cmd
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlInsert;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
            }
            // Step 4: close connection
            finally
            {
                conn.Close();
            }
            //Console.WriteLine("data saved....");
        }

        public void Update(Employee empToUpdate)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EmpDatabase;Integrated Security=True";
            conn.Open();
            //Console.WriteLine("connected to db");

            // Step 2: prepare sql insert cmd
            //string sqlInsert = $"insert into employees values ('{empToSave.Name}',{empToSave.Salary})";
            string update = $"update employees set name = '{empToUpdate.Name}', salary = {empToUpdate.Salary} where empid ={empToUpdate.EmpID} ";
            // Step 3: exe sql cmd
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = update;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
            }
            // Step 4: close connection
            finally
            {
                conn.Close();
            }
        }
    }
}
