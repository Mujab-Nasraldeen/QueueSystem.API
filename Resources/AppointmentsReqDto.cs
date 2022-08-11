using System.ComponentModel.DataAnnotations;

namespace QueueSystem.API.Resources
{
    public class AppointmentsReqDto
    {
        [Required]
        public Guid PatientId { get; set; }

        [Required]
        public Guid DoctorId { get; set; }

        [Required]
        public int AppointmentId { get; set; }
    }
}
