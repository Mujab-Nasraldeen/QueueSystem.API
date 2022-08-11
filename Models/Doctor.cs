using System.ComponentModel.DataAnnotations;

namespace QueueSystem.API.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }

        [Required, MaxLength(250)]
        public string FullName { get; set; }

        [Required, MaxLength(100)]
        public string Specification { get; set; }

        [Required, MaxLength(15)]
        public string Phone { get; set; }
    }
}
