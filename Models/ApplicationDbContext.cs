using Microsoft.EntityFrameworkCore;

namespace QueueSystem.API.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Appointment Default Data
            modelBuilder.Entity<Appointment>().HasData(new Appointment { Id = 1, AppointmentDate = "Sunday 9:00 AM" });
            modelBuilder.Entity<Appointment>().HasData(new Appointment { Id = 3, AppointmentDate = "Sunday 6:00 PM" });
            modelBuilder.Entity<Appointment>().HasData(new Appointment { Id = 2, AppointmentDate = "Wednesday 10:00 AM" });
            modelBuilder.Entity<Appointment>().HasData(new Appointment { Id = 4, AppointmentDate = "Wednesday 7:00 PM" });
            #endregion

            #region Patient Default Data
            modelBuilder.Entity<Patient>().HasData(new Patient { Id = Guid.NewGuid(), UserName = "Waleed", FullName = "Waleed Mohanned Hassan", Gender = "Male" });
            modelBuilder.Entity<Patient>().HasData(new Patient { Id = Guid.NewGuid(), UserName = "Ahmed", FullName = "Ahmed Aziz Abas", Gender = "Male" });
            modelBuilder.Entity<Patient>().HasData(new Patient { Id = Guid.NewGuid(), UserName = "Duaa", FullName = "Duaa Nasraldeen Othman", Gender = "Female" });
            modelBuilder.Entity<Patient>().HasData(new Patient { Id = Guid.NewGuid(), UserName = "Mujab", FullName = "Mujab Nasraldeen Othman", Gender = "Male" });
            #endregion

            #region Doctor Default Data
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = Guid.NewGuid(), FullName = "Migdam Adil Yousif", Specification = "Esoteric", Phone = "0928077666" });
            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id = Guid.NewGuid(), FullName = "Mogtaba Saifaldeen Mohammed", Specification = "General", Phone = "0928077888" });
            #endregion
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<PatientAppointment> PatientAppointments { get; set; }
    }
}
