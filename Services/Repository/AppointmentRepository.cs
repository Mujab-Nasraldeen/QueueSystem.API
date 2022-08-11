using QueueSystem.API.Models;

namespace QueueSystem.API.Services.Repository
{
    public interface IAppointmentRepository : IBaseRepository<Appointment>
    {

    }

    #region Implementation
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
    #endregion
}
