using ScheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces {
    public interface IScheduleRepository {
        public IEnumerable<Schedule> Get();
        public void Create(Schedule schedule);
        public void Edit(int Id, Schedule schedule);
        public void  Delete(Schedule schedule);
    }
}
