using razorPageExamples.Models;

namespace razorPageExamples.Repository;

public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employees;

    public MockEmployeeRepository()
    {
        _employees = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "Lebron James", Email = "info@james.com", Photo = "lbrn.jpg", Department = "Basketball Team" },
            new Employee() { Id = 2, Name = "Kobe Bryant", Email = "info@kobe.com", Photo = "kobe.jpg", Department = "Basketball Team" },
            new Employee() { Id = 3, Name = "Lewis Hamilton", Email = "info@lewis.com", Photo = "Lewis.jpeg", Department = "F1 Team" },
            new Employee() { Id = 4, Name = "Conor McGregor", Email = "info@conor.com", Photo = "conor.jpg", Department = "UFC Team" },
        };
    }
    
    public IEnumerable<Employee> GetAllEmployees()
    {
        return _employees;
    }
    

    public Employee GetById(int id)
    {
        return _employees.FirstOrDefault(x => x.Id == id);
    }

    public Employee Update(Employee employee)
    {
        Employee updatedEmployee = _employees.FirstOrDefault(x => x.Id == employee.Id);

        if (updatedEmployee != null)
        {
            updatedEmployee.Name = employee.Name;
            updatedEmployee.Email = employee.Email;
            updatedEmployee.Photo = employee.Photo;
            updatedEmployee.Department = employee.Department;
        }
        return updatedEmployee;
    }
}