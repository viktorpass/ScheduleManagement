using System.Diagnostics.CodeAnalysis;

namespace ScheduleManagement.Models {
    public class User {
        public int Id { get; private set; }
        [NotNull]
        public string Username { get; set; }
        [NotNull]
        public string Email { get; set; }
        [NotNull]
        public string Password { get; set; }




    }
}
