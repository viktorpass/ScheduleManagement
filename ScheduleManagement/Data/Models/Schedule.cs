using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ScheduleManagement.Models {
    public class Schedule {
        
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; }
        [AllowNull]
        public string? Description { get; set; }
        [NotNull]
        public DateTime LocalDate { get; set; }

        public string ExclusiveOrShared { get; set; }
        public string Members { get; set; }

        public int UserId { get; set; }
        public ICollection<User>? User { get; set; }



    }
}
