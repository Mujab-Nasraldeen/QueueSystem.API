using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QueueSystem.API.Models;
using QueueSystem.API.Resources;
using QueueSystem.API.Services;

namespace QueueSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientAppointmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PatientAppointmentsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("WaitScreen")]
        public async Task<IActionResult> WaitScreen()
        {
            try
            {
                var pAppointments = await _unitOfWork.PatientAppointment.GetAll()
                .Include(p => p.Patient)
                .ToListAsync();

                var response = _mapper.Map<List<PatientAppointment>, List<PatientAppointmentRespDto>>(pAppointments);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("CallingPatientAgain")]
        public async Task<IActionResult> CallingPatientAgain()
        {
            try
            {
                var callPatients = await _unitOfWork.PatientAppointment.GetMany(p => p.IsPresent == false)
                .Include(p => p.Patient)
                .ToListAsync();

                var response = _mapper.Map<List<PatientAppointment>, List<PatientAppointmentRespDto>>(callPatients);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AssignPatientToDoctor")]
        public async Task<IActionResult> AssignPatientToDoctor(AppointmentsReqDto req)
        {
            try
            {
                var pAppointment = _mapper.Map<AppointmentsReqDto, PatientAppointment>(req);

                await _unitOfWork.PatientAppointment.AddAsync(pAppointment);
                await _unitOfWork.Commit();

                return Ok("Assign Patient To Doctor Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
