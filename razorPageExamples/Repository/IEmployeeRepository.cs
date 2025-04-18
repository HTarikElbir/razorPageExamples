using razorPageExamples.Models;

namespace razorPageExamples.Repository;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAllEmployees();
}