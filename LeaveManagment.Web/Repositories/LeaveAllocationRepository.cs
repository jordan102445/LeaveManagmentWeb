using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Constraints;
using Microsoft.AspNetCore.Identity;
using System.Data;
using Microsoft.EntityFrameworkCore;
using LeaveManagment.Web.Models;
using AutoMapper;
using System.Security.Policy;

namespace LeaveManagment.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly IleaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;
        public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager,
            IleaveTypeRepository leaveTypeRepository,IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeid, int leaveTypeid, int period)
        {


            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeid
            && q.LeaveTypeId == leaveTypeid
            && q.Period == period
                );
        
        
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocation = await context.LeaveAllocations.
                 Include(q => q.LeaveType) // inner join na leaveallocation i leavetype tabelite za taj korisnik zaednickito SQL // spored toj leavetype
                  .Where(q => q.EmployeeId == employeeId).ToListAsync();    
                 
                   
           var employee = await userManager.FindByIdAsync(employeeId);

            var EmployeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);

            EmployeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocation);   
            
            return EmployeeAllocationModel;
         }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {
                var allocation = await context.LeaveAllocations.
                Include(q => q.LeaveType).
                FirstOrDefaultAsync(q => q.Id == id);

            if (allocation == null)
            {
                return null;
            }

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);

            var model = mapper.Map<LeaveAllocationEditVM>(allocation);  // se kopira ili so mapper se zima se od allocation i se stava vo leaveallocationEditVM
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId));

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeid)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var peroid = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeid); // detali za leavetypes zimame preku id nivno
            var allocations = new List<LeaveAllocation>();


            foreach(var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeid, peroid)) // ako ima vise postoat takvi vraboteni break ako ne postoat se kreirat 
                    continue;
               allocations.Add( new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeid,
                    Period = peroid,
                    NumberOfDays = leaveType.DeafultDays
                });

            
            }
            
           await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM leaveAllocationEdit)
        {
            var leaveAllocaiton = await GetAsync(leaveAllocationEdit.id);
            if (leaveAllocaiton == null)
            {
                return false;
            }
            leaveAllocaiton.Period = leaveAllocationEdit.Period;
            leaveAllocaiton.NumberOfDays = leaveAllocationEdit.NumberOfDays;
            await UpdateAsync(leaveAllocaiton);

            return true;
        }
    }
}
