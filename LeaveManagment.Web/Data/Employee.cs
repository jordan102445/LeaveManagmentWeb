using Microsoft.AspNetCore.Identity;
using System.Data;

namespace LeaveManagment.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? TaxID { get; set; }
        
        public DateTime DateofBirth { get; set; } 
        
        public DateTime DateJoined { get; set; }

    }
}
