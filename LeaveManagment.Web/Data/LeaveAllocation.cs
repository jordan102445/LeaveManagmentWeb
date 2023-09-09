using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagment.Web.Data
{
    public class LeaveAllocation : BaseEntiy
    {

      

        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")] // data notiation ili pocetuvanje na se foreing key
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }  

       

    }
}
