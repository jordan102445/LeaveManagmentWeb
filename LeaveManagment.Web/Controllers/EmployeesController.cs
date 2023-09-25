using LeaveManagment.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LeaveManagment.Web.Constraints;
using AutoMapper;
using LeaveManagment.Web.Models;
using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Repositories;

namespace LeaveManagment.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IleaveTypeRepository leaveTypeRepository;

        public EmployeesController(UserManager<Employee> userManager, IMapper mapper,ILeaveAllocationRepository leaveAllocationRepository,IleaveTypeRepository leaveTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);//zima gi listata na employees ready to display
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/employeeId
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model); // contollero prave display od data model na view model
        }

       

        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var leaveAllocationmodel = await leaveAllocationRepository.GetEmployeeAllocation(id);
            if (leaveAllocationmodel == null)
            {
                return NotFound();
            }
             

            return View(leaveAllocationmodel);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> EditAllocation(int id,LeaveAllocationEditVM leavemodel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if (await leaveAllocationRepository.UpdateEmployeeAllocation(leavemodel))
                    {
                        return RedirectToAction(nameof(ViewAllocations), new { id = leavemodel.EmployeeId });
                    }

                    
                }
                
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty,"An Error Has Occurred. Please Try Again Later");
                
            }

            leavemodel.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leavemodel.EmployeeId)); // prvo za first n lastname vo views(editallocation)
            leavemodel.LeaveType = mapper.Map<LeaveTypeVM_View_Model_>(await leaveTypeRepository.GetAsync(leavemodel.LeaveTypeId));
            return View(leavemodel);
        }

     
        
    }
}
