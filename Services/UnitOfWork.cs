using QueueSystem.API.Models;
using QueueSystem.API.Services.Repository;

namespace QueueSystem.API.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IAppointmentRepository _appointment;
        private IPatientRepository _patient;
        private IDoctorRepository _doctor;
        private IPatientAppointmentRepository _patientAppointment;

        public UnitOfWork(ApplicationDbContext dbcontext)
        {
            _context = dbcontext;
        }

        #region Appointment
        public IAppointmentRepository Appointment
        {
            get
            {
                if(_appointment == null)
                {
                    _appointment = new AppointmentRepository(_context);
                }

                return _appointment;
            }
        }
        #endregion

        #region Patient
        public IPatientRepository Patient
        {
            get
            {
                if(_patient == null)
                {
                    _patient = new PatientRepository(_context);
                }

                return _patient;
            }
        }
        #endregion

        #region Doctor
        public IDoctorRepository Doctor
        {
            get
            {
                if(_doctor == null)
                {
                    _doctor = new DoctorRepository(_context);
                }

                return (_doctor);
            }
        }
        #endregion

        #region patientAppointment
        public IPatientAppointmentRepository PatientAppointment
        {
            get
            {
                if(_patientAppointment == null)
                {
                    _patientAppointment = new PatientAppointmentRepository(_context);
                }

                return (_patientAppointment);
            }
        }
        #endregion

        #region Commit
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion
    }
}
