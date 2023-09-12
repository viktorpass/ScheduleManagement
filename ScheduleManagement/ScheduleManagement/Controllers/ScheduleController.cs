using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ScheduleManagement.Models;

namespace ScheduleManagement.Controllers {

    public class ScheduleController : Controller {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleController(IScheduleRepository scheduleRepository) {
            _scheduleRepository = scheduleRepository;
        }


        public IActionResult ScheduleIndex() {
            var data = _scheduleRepository.Get();
            return View(data);
        }


        public IActionResult CreateSchedule() {
            return View();
        }


        [HttpGet]
        public IActionResult Delete(int Id) {
            Schedule schedule = _scheduleRepository.Get().FirstOrDefault(i => i.Id == Id);


            return View(schedule);
        } 


        [HttpPost]
        public void Delete(Schedule schedule) {
            
            _scheduleRepository.Delete(schedule);

        }




    }
}
