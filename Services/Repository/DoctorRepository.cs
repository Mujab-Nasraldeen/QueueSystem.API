using QueueSystem.API.Models;

namespace QueueSystem.API.Services.Repository
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {

    }

    #region Implementation
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
    #endregion
}
