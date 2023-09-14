using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ScheduleManagement.Models;
using System.Linq.Expressions;

namespace ScheduleManagement.Controllers {

    public class ScheduleController : Controller {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleController(IScheduleRepository scheduleRepository) {
            _scheduleRepository = scheduleRepository;
        }


        public IActionResult ScheduleIndex() {
            try {

                var data = _scheduleRepository.Get();
                if(data is null) {
                    return StatusCode(StatusCodes.Status404NotFound);
                }
                return View(data);
            }
            catch {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        public IActionResult CreateSchedule() {
            return View();
        }


        [HttpGet]
        public IActionResult Delete(int Id) {
            try {
                Schedule schedule = _scheduleRepository.Get().FirstOrDefault(i => i.Id == Id);
                if(schedule is null) {
                    return StatusCode(StatusCodes.Status404NotFound);
                }

                return View(schedule);
            }
            catch {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
            
        }


        [HttpPost]
        public IActionResult Delete(Schedule schedule) {

            try {
                if(schedule is null) {
                    return StatusCode(StatusCodes.Status404NotFound);
                }
                _scheduleRepository.Delete(schedule);

                return RedirectToAction("ScheduleIndex");
            }
            catch {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            
        }

        [HttpGet]
        public IActionResult Edit(int Id) {


            try {
                Schedule schedule = _scheduleRepository.Get().FirstOrDefault(i => i.Id == Id);
                if (schedule is null) {
                    return StatusCode(StatusCodes.Status404NotFound);

                }
                return View(schedule);

            }
            catch (Exception){
                return StatusCode(500);
            }

           

        }
        [HttpPost]
        
        public IActionResult Edit(Schedule schedule) {
            try {
                if(schedule is null) {
                    return StatusCode(StatusCodes.Status404NotFound);
                }
                _scheduleRepository.Edit(schedule);

                return RedirectToAction("ScheduleIndex");
            }
            catch {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
            
        }




    }
}
