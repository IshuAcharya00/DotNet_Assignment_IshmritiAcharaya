using System;
using System.ComponentModel.DataAnnotations;

namespace Ishmirt_Acharya_Dot_Net_Assignment.Models
{
    public class Manage
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Start Time")]
        public TimeSpan StartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "End Time")]
        public TimeSpan EndTime { get; set; }

        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }
    }
}
