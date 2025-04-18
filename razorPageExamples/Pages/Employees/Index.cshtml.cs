using Microsoft.AspNetCore.Mvc.RazorPages;
using razorPageExamples.Models;
using razorPageExamples.Repository; 

namespace razorPageExamples.Pages.Employees;

public class IndexModel : PageModel
{
    public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
    private readonly IEmployeeRepository _employeeRepository;
    public IndexModel(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    public void OnGet()
    {
        Employees = _employeeRepository.GetAllEmployees();
    }
}