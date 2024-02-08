using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication7.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }
    }
}
