using razorPageExamples.Models;

namespace razorPageExamples.Repository;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAllEmployees();
    Employee GetById(int id);
    Employee Update(Employee employee);
}