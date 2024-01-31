using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models
{
    [Table("Doctors")]
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? DateOfBirth { get; set; }
        public string Office {  get; set; }
        List<Patient> Patients { get; set; }
    }
}