using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class LeaveTypeVM_View_Model_
    {
        public int Id { get; set; }
        [Display (Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display (Name = "Default Number of Days")] // DataAnnotations 

        [Required]
        [Range (1, 25, ErrorMessage = "Please Enter A Valid Number")]
        
        public int DeafultDays { get; set; }

        

    }
}
