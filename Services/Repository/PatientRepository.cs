using QueueSystem.API.Models;

namespace QueueSystem.API.Services.Repository
{
    public interface IPatientRepository : IBaseRepository<Patient>
    {

    }

    #region Implementation
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
    #endregion
}
