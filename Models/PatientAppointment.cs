using Microsoft.EntityFrameworkCore;
using QueueSystem.API.Helper;
using System.ComponentModel.DataAnnotations;

namespace QueueSystem.API.Models
{
    [Index(nameof(TicketReferenceId))]
    public class PatientAppointment
    {
        public PatientAppointment()
        {
            TicketReferenceId = Common.GenerateTicketReferenceId();
            IsPresent = true;
            CreatedDate = DateTime.Now;
        }

        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string TicketReferenceId { get; set; }

        [Required]
        public bool IsPresent { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
