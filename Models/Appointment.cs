using System.ComponentModel.DataAnnotations;

namespace QueueSystem.API.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string AppointmentDate { get; set; }
    }
}
