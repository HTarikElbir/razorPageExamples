using razorPageExamples.Models;

namespace razorPageExamples.Repository;

public interface IEmployeeRespository
{
    IEnumerable<Employee> GetAllEmployees();
}