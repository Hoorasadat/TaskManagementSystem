using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.BLL.Interfaces;
using TaskManagementSystem.Lib.Models;

namespace TaskManagementSystem.WEB.Controllers
{
    public class DutyController : Controller
    {
        private readonly IDutyRepository _dutyRepository;

        public DutyController(IDutyRepository dutyRepository)
        {
            _dutyRepository = dutyRepository;
        }


        // GET: /duty/index
        public async Task<ViewResult> Index(int id)
        {
            IList<Duty> duties = await _dutyRepository.GetAllDuties();

            ViewBag.Header = "List of All Tasks:";
            ViewBag.Duties = duties;

            return View(duties);
        }

        // GET: /duty/details/id
        public async Task<ViewResult> Details(int id)
        {
            Duty duty = await _dutyRepository.GetDuty(id);

            ViewData["Header"] = "Task Details:";
            ViewData["Duty"] = duty;
            
            return View();
        }
    }
}

