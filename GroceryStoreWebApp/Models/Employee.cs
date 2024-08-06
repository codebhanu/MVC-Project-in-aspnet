using System.ComponentModel.DataAnnotations;

namespace GroceryStoreWebApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [MaxLength(10)]
        public string? FirstName { get; set; }

        [MaxLength(10)]
        public string? LastName { get; set; }

        [EmailAddress]
        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(50)]
        public string? PhoneNumber { get; set; }

        [MaxLength(10)]
        public string? JobTitle { get; set; }

        public double Salary { get; set; }
    }
}
