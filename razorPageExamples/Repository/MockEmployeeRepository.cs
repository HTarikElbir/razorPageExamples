using razorPageExamples.Models;

namespace razorPageExamples.Repository;

public class MockEmployeeRepository : IEmployeeRespository
{
    private List<Employee> _employees;

    public MockEmployeeRepository()
    {
        _employees = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "Lebron James", Email = "info@james.com", Photo = "1.jpg", Department = "Basketball Team" },
            new Employee() { Id = 2, Name = "Kobe Bryant", Email = "info@kobe.com", Photo = "2.jpg", Department = "Basketball Team" },
            new Employee() { Id = 3, Name = "Lewis Hamilton", Email = "info@lewis.com", Photo = "3.jpg", Department = "F1 Team" },
            new Employee() { Id = 4, Name = "Conor McGregor", Email = "info@conor.com", Photo = "4.jpg", Department = "UFC Team" },
        };
    }
    
    public IEnumerable<Employee> GetAllEmployees()
    {
        return _employees;
    }
}