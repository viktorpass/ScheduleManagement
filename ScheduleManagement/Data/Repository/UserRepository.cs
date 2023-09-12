using Data.Interfaces;
using ScheduleManagement.Context;
using ScheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository {
    public class UserRepository : IUserRepository {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) {
            _context = context;
        }

        public void Login() {
            _context.User.ToList();
        }

        public void Register() {
            _context.User.ToList();
        }
    }
}
