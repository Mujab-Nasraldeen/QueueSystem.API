using QueueSystem.API.Services.Repository;

namespace QueueSystem.API.Services
{
    public interface IUnitOfWork
    {
        IAppointmentRepository Appointment { get; }
        IPatientRepository Patient { get; }
        IDoctorRepository Doctor { get; }
        IPatientAppointmentRepository PatientAppointment { get; }
        Task Commit();
    }
}
