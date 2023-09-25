using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Data;
using Microsoft.AspNet.Identity;
using System.Drawing.Text;

namespace LeaveManagment.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, IleaveTypeRepository
    {

       
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
