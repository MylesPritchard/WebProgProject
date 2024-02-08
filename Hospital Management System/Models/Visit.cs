using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models
{
    [Table("Visits")]
    public class Visit
    {
        [Display(Name = "Visit ID")]
        public int VisitID { get; set; }
        [Display(Name = "Date of Visist")]
        public string DateOfVisit { get; set; }
        public string? Complaint { get; set; }
        public virtual Doctor? Doctor { get; set; }
        public int? DoctorID { get; set; }
        public virtual Patient? Patient { get; set; }
        public int? PatientID { get; set; }
    }
}