using Microsoft.AspNetCore.Mvc.RazorPages;
using razorPageExamples.Models;
using razorPageExamples.Repository;

namespace razorPageExamples.Pages.Employees;

public class Edit : PageModel
{
    private readonly IEmployeeRepository _employeeRepository;

    public Edit(IEmployeeRepository employeeRepository )
    {
        _employeeRepository = employeeRepository;
    }
    public Employee Employee { get; set; } = null!;
    
    public void OnGet(int id)
    {
        Employee = _employeeRepository.GetById(id);
    }
}