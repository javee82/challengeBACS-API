using Infrastructure.DataManager;
using Infrastructure.ViewModels.Request.Patient;
using Models.Data;
using Repository;
using Services.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class PatientService : PatientDataManager, IPatientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Patient> AddAsync(ICreatePatientRequest request)
        {
            var patient = new Patient();
            SetValues(patient, request);
            SetPerson(patient, request);
            await _unitOfWork.Patients.AddAsync(patient);
            await _unitOfWork.Save();
            return patient;
        }

        public async Task DeleteAsync(Guid Id)
        {
            var patient = await _unitOfWork.Patients.GetAsync(Id);
            if (patient != null)
            {
				await _unitOfWork.Patients.DeleteAsync(Id);
				await _unitOfWork.Save();
			}
			else
                throw new Exception("Patient not found");
        }

        public async Task<IEnumerable<Patient>> GetAllAsync() => await _unitOfWork.Patients.GetAllAsync();

        public async Task<Patient> GetAsync(Guid Id)
        {
            var patient = await _unitOfWork.Patients.GetAsync(Id);
            if (patient != null)
                return patient;
            else
                throw new Exception("Patient not found");
        }

        public async Task<Patient> UpdateAsync(IEditPatientRequest request)
        {
            var patient = await GetAsync(request.Id);
            SetValues(patient, request);
            SetPerson(patient, request);
			_unitOfWork.Patients.UpdateAsync(patient);
			await _unitOfWork.Save();
            return patient;
        }
    }
}
