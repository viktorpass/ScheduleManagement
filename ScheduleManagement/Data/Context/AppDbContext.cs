using Microsoft.EntityFrameworkCore;
using ScheduleManagement.Models;

namespace ScheduleManagement.Context
{
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Schedule> Schedule { get; set; }


    }
}
