using Microsoft.AspNetCore.Mvc.RazorPages;
using razorPageExamples.Models;
using razorPageExamples.Repository;

namespace razorPageExamples.Pages.Employees;

public class DetailsModel : PageModel
{
    private  readonly IEmployeeRepository _employeeRepository;
    public Employee Employee { get; set; } = default!;

    public DetailsModel(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    
    public void OnGet(int id)
    {
       Employee = _employeeRepository.GetById(id);
    }
}