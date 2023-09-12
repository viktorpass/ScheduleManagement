using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using ScheduleManagement.Context;
using ScheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository {
    public class ScheduleRepository : IScheduleRepository {
        private readonly AppDbContext _context;

        public ScheduleRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<Schedule> Get() {
            return _context.Schedule.AsNoTracking().ToList();
            

        }

        public void Create(Schedule schedule) {
            _context.Schedule.Add(schedule);
            _context.SaveChanges();
           
        }

        public void Delete(Schedule schedule) {
            _context.Remove(schedule);
            _context.SaveChanges();
        }

        public void Edit(int Id, Schedule schedule) {
            _context.Update(schedule);
            _context.SaveChanges();
        }

     

       
    }
}
