using LeaveManagment.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class LeaveAllocationVM 
    {
        [Required]
        public int id { get; set; } // allow admin to edit a leaveallocation

        
        [Display (Name = "Number of Days")]
        [Required]
        [Range (1,50,ErrorMessage ="Invalid Number Entered")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Allocation Period")]
        [Required]
        public int Period { get; set; }

        public LeaveTypeVM_View_Model_? LeaveType { get; set; }


       


    }
}