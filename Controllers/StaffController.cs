using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using kwezi_health_esop.Services;
using kwezi_health_esop.Models;

namespace kwezi_health_esop.Controllers
{
    [Authorize]
    public class StaffController : Controller
    {
        private readonly StaffService _staffService;

        public StaffController(StaffService staffService)
        {
            _staffService = staffService;
        }

        public IActionResult Index()
        {
            var staffList = _staffService.GetAllStaff();
            return View(staffList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(StaffMember staff)
        {
            if (ModelState.IsValid)
            {
                _staffService.Add(staff);
                return RedirectToAction("Index");
            }
            return View("Index", _staffService.GetAllStaff());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var staff = _staffService.GetById(id);
            if (staff == null)
            {
                return NotFound();
            }

            ViewBag.EditingStaff = staff;
            return View("Index", _staffService.GetAllStaff());
        }

        [HttpPost]
        public IActionResult Edit(StaffMember staff)
        {
            if (ModelState.IsValid)
            {
                _staffService.Update(staff);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _staffService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
