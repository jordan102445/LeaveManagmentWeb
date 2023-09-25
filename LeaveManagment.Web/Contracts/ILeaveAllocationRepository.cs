using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeid);

        Task<bool> AllocationExists(string employeeid,int leaveTypeid,int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);

        
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);

        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM leaveAllocationEdit);

    }
}
