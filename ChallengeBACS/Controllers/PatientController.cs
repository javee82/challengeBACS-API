using Infrastructure.ViewModels.Request.Patient;
using Infrastructure.ViewModels.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Infrastructure.Interfaces;
using Infrastructure.Mapper;
using Models.ViewModels.PatientVM;

namespace ChallengeBACS.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class PatientController : ControllerBase
	{
		private readonly IPatientService _patientService;

		public PatientController(IPatientService patientService)
		{
			_patientService = patientService;
		}

		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] GetPatientRequest request)
		{
			try
			{
				var response = new BaseResponse();
				var patient = await _patientService.GetAsync(request.Id);
				var patientVM = new PatientVM();
				PatientMapper.Map(patient, patientVM);
				response.Body = patientVM;
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
				var patient = await _patientService.GetAllAsync();
				var patientsVM = patient.Select(p =>
				{
					var patientVM = new PatientVM();
					PatientMapper.Map(p, patientVM);
					return patientVM;
				}).ToList();

				response.Body = patientsVM;
				response.Success = true;
				return Ok(response);
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		[HttpPost]
		public async Task<IActionResult> Add([FromBody] CreatePatientRequest request)
		{
			try
			{
				var response = new BaseResponse();
				var patient = await _patientService.AddAsync(request);
				var patientVM = new PatientVM();
				PatientMapper.Map(patient, patientVM);
				response.Body = patientVM;
				response.Success = true;
				return Ok(response);
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		[HttpPut]
		public async Task<IActionResult> Update([FromBody] EditPatientRequest request)
		{
			try
			{
				var response = new BaseResponse();
				var patient = await _patientService.UpdateAsync(request);
				var patientVM = new PatientVM();
				PatientMapper.Map(patient, patientVM);
				response.Body = patientVM;
				response.Success = true;
				return Ok(response);
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		[HttpDelete]
		public async Task<IActionResult> Delete([FromQuery] GetPatientRequest request)
		{
			try
			{
				var response = new BaseResponse();
				await _patientService.DeleteAsync(request.Id);
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
