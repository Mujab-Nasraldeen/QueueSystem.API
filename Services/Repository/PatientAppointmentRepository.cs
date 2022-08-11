using QueueSystem.API.Models;

namespace QueueSystem.API.Services.Repository
{
    public interface IPatientAppointmentRepository : IBaseRepository<PatientAppointment>
    {

    }

    #region Implementation
    public class PatientAppointmentRepository : BaseRepository<PatientAppointment>, IPatientAppointmentRepository
    {
        public PatientAppointmentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
    #endregion
}
