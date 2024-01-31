using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models
{
    [Table("Visits")]
    public class Visit
    {
        public int VisitID { get; set; }
        public string DateOfVisit { get; set; }
        public string Complaint { get; set; }
        public virtual Doctor? Doctor { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}