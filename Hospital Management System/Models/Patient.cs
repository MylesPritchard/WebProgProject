using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models
{
    [Table("Patients")]
    public class Patient
    {
        [Display(Name = "Patient ID")]
        public int PatientID { get; set; }
        [Required(ErrorMessage = "Please enter the patient's name.")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "Doctor ID")]
        public int? DoctorID { get; set; } //a forign key must be nullable
        public virtual Doctor? Doctor { get; set; } //nullable
        [DataType(DataType.Date)]
        public DateTime? Admitted { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Discharged { get; set; }
    }
}