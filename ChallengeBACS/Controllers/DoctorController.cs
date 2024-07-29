using Infrastructure.Mapper;
using Infrastructure.ViewModels.Request;
using Infrastructure.ViewModels.Request.Doctor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.DoctorVM;
using Services.Infrastructure.Interfaces;

namespace ChallengeBACS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetDoctorRequest request)
        {            
            try
            {
                var response = new BaseResponse();
                var doctor = await _doctorService.GetAsync(request.Id);
                var doctorVM = new DoctorVM();
                DoctorMapper.Map(doctor, doctorVM);
                response.Body = doctorVM;
                response.Success = true;
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = new BaseResponse();
                var doctor = await _doctorService.GetAllAsync();
                var doctorsVM = doctor.Select(d =>
                {
                    var doctorVM = new DoctorVM();
                    DoctorMapper.Map(d, doctorVM);
                    return doctorVM;
                }).ToList();
                
                response.Body = doctorsVM;
                response.Success = true;
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateDoctorRequest request)
        {            
            try
            {
                var response = new BaseResponse();
                var doctor = await _doctorService.AddAsync(request);
                var doctorVM = new DoctorVM();
                DoctorMapper.Map(doctor, doctorVM);
                response.Body = doctorVM;
                response.Success = true;
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] EditDoctorRequest request)
        {            
            try
            {
                var response = new BaseResponse();
                var doctor = await _doctorService.UpdateAsync(request);
                var doctorVM = new DoctorVM();
                DoctorMapper.Map(doctor, doctorVM);
                response.Body = doctorVM;
                response.Success = true;
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] GetDoctorRequest request)
        {            
            try
            {
                var response = new BaseResponse();
                await _doctorService.DeleteAsync(request.Id);
                response.Success = true;
                return Ok(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
