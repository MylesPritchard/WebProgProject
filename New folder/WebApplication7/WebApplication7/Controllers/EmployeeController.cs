using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class EmployeeController : Controller
    {
        private ContextClass dbContext;
        public EmployeeController (ContextClass dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Employee> employees = dbContext.Employees.ToList();

            return View(employees);
        }
    }
}
