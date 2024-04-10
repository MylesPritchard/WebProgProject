using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models
{
    [Table("Doctors")]
    public class Doctor
    {
        [Display(Name = "Doctor ID")]
        public int DoctorID { get; set; }

        [Required(ErrorMessage = "Please enter the doctor's {0}.")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the doctor's Email Address.")]
        [EmailAddress(ErrorMessage = "The Email Address is not valid.")]
        [MaxLength(360)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the doctor's {0}.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string Address { get; set; }

        [Display(Name="Phone Number")]
        [Required(ErrorMessage = "Please enter the doctor's {0}.")]
        [Phone(ErrorMessage = "The {0} is not valid.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Date of Birth")]
        public string? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter the doctor's {0}.")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Office {  get; set; }

        [Required(ErrorMessage = "Please enter the doctor's {0}.")]
        List<Patient> Patients { get; set; }

        public string? Type {  get; set; }
    }
}