using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagment.Web.Data;
using AutoMapper;
using LeaveManagment.Web.Models;
using LeaveManagment.Web.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagment.Web.Constraints;
// 
namespace LeaveManagment.Web.Controllers
{
    [Authorize (Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        private IleaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public LeaveTypesController(IleaveTypeRepository leaveTypeRepository, IMapper mapper
            , ILeaveAllocationRepository leaveAllocationRepository )
        {
                this.leaveTypeRepository = leaveTypeRepository;
                this.mapper = mapper;
                this.leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            //return _context.LeaveTypes != null ? 
            //View(await _context.LeaveTypes.ToListAsync()) :
            //Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");

            // var leaveTypes = mapper.Map<List<LeaveTypeVM_View_Model_>>(await _context.LeaveTypes.ToListAsync());
            
            var leaveTypes = mapper.Map<List<LeaveTypeVM_View_Model_ >> (await leaveTypeRepository.GetAllAsync());
            return View(leaveTypes);

            // zaradi GenericRepository --> ima funckija GetallAsync();
        }


        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            // if (id == null || _context.LeaveTypes == null)
            // {
            //return NotFound();
            //}

            //var leaveType = await _context.LeaveTypes
            // .FirstOrDefaultAsync(m => m.Id == id);
            // if (leaveType == null)
            // {
            // return NotFound();
            //}

            //return View(leaveType);


            
           

            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM_View_Model_>(leaveType);
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM_View_Model_ leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVM); // convert od viewmodel vo datamodel 
                await leaveTypeRepository.AddAsync(leaveType);                        // LeaveType(bazata)<---leavetypeVM
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //if (id == null || _context.LeaveTypes == null)
            //{
                //return NotFound();
            //}

            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM_View_Model_>(leaveType);
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM_View_Model_ leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
            //if (id == null || _context.LeaveTypes == null)
            //{
               // return NotFound();
            //}

          //  var leaveType = await _context.LeaveTypes
               // .FirstOrDefaultAsync(m => m.Id == id);
           // if (leaveType == null)
           // {
               // return NotFound();
           // }

            //return View(leaveType);
       // }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           
            
             await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //private async Task<bool> LeaveTypeExists(int id)
        //{
        //return await leaveTypeRepository.Exists(id);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AllocateLeave(int id)
        {

          await leaveAllocationRepository.LeaveAllocation(id);
          return RedirectToAction(nameof(Index));
        }
    }
}
