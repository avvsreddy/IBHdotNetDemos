using EmployeeManagementApp.Entities;

namespace EmployeeManagementApp.DataAccess
{
    public interface IEmployeeRepository
    {
        void Save(Employee empToSave);
        void Update(Employee empToUpdate);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="empid"></param>
        /// <exception cref="EmployeeNotFoundException"></exception>
        void Delete(int empid);

        List<Employee> GetEmployees();
        Employee GetEmployee(int empid);

    }
}
