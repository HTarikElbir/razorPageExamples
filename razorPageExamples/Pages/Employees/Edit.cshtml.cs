using Microsoft.AspNetCore.Mvc;
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
    
    [BindProperty]
    public Employee Employee { get; set; } = null!;
    
    public void OnGet(int id)
    {
        Employee = _employeeRepository.GetById(id);
    }

    // public IActionResult OnPost(Employee employee)
    // {
    //     Employee = _employeeRepository.Update(employee);
    //     return RedirectToPage("/Employees/Index");
    // }
    //
    
    public IActionResult OnPost()
    {
        Employee = _employeeRepository.Update(Employee);  // Second way to update the employee
        return RedirectToPage("/Employees/Index");
    }
}