using System.ComponentModel.DataAnnotations;

namespace QueueSystem.API.Models
{
    public class Patient
    {
        //[Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(250)]
        public string FullName { get; set; }

        [Required, MaxLength(10)]
        public string Gender { get; set; }
    }
}
