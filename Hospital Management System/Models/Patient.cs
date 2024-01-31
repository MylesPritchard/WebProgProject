using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models
{
    [Table("Patients")]
    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? DateOfBirth { get; set; }
        public int? DoctorID { get; set; } //a forign key must be nullable
        public virtual Doctor? Doctor { get; set; } //nullable
    }
}