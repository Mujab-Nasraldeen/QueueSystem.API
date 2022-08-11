using AutoMapper;
using QueueSystem.API.Models;
using QueueSystem.API.Resources;

namespace QueueSystem.API.Helper.Mapping
{
    public class AutoMappersProfiles : Profile
    {
        public AutoMappersProfiles()
        {
            CreateMap<PatientAppointment, PatientAppointmentRespDto>()
                .ForMember(p => p.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(p => p.UserName, opt => opt.MapFrom(x => x.Patient.UserName))
                .ForMember(p => p.FullName, opt => opt.MapFrom(x => x.Patient.FullName))
                .ForMember(p => p.Gender, opt => opt.MapFrom(x => x.Patient.Gender));

            CreateMap<AppointmentsReqDto, PatientAppointment>()
                .ForMember(p => p.PatientId, opt => opt.MapFrom(x => x.PatientId))
                .ForMember(p => p.DoctorId, opt => opt.MapFrom(x => x.DoctorId))
                .ForMember(p => p.AppointmentId, opt => opt.MapFrom(x => x.AppointmentId));
        }
    }
}
