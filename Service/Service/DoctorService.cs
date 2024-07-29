using Infrastructure.DataManager;
using Infrastructure.ViewModels.Request.Doctor;
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
    public class DoctorService : DoctorDataManager, IDoctorService
    {        
        private readonly IUnitOfWork _unitOfWork;


        public DoctorService(IUnitOfWork unitOfWork)
        {            
            _unitOfWork = unitOfWork;
        }

        public async Task<Doctor> AddAsync(ICreateDoctorRequest request)
        {
            var doctor = new Doctor();
            SetValues(doctor, request);
            SetPerson(doctor, request);
            await _unitOfWork.Doctors.AddAsync(doctor);
            await _unitOfWork.Save();
            return doctor;
        }

        public async Task DeleteAsync(Guid Id)
        {
            var doctor = await _unitOfWork.Doctors.GetAsync(Id);
            if (doctor != null)
            {
                await _unitOfWork.Doctors.DeleteAsync(Id);
                await _unitOfWork.Save();
            }                
            else           
                throw new Exception("Doctor not found");
        }

        public async Task<Doctor> GetAsync(Guid Id)
        {
            var doctor = await _unitOfWork.Doctors.GetAsync(Id);
            if (doctor != null)
                return doctor;            
            else
                throw new Exception("Doctor not found");
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync() => await _unitOfWork.Doctors.GetAllAsync();

        public async Task<Doctor> UpdateAsync(IEditDoctorRequest request)
        {
            var doctor = await GetAsync(request.Id);       
            SetValues(doctor, request);
            SetPerson(doctor, request);
            _unitOfWork.Doctors.UpdateAsync(doctor);
            await _unitOfWork.Save();
            return doctor;
        }
    }
}
