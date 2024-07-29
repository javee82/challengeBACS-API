using Infrastructure.Interfaces.Models;
using Infrastructure.ViewModels.Request.Doctor;
using Models.Data;
using Models.ViewModels.DoctorVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infrastructure.Interfaces
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetAllAsync();
        Task<Doctor> GetAsync(Guid Id);
        Task<Doctor> AddAsync(ICreateDoctorRequest request);
        Task<Doctor> UpdateAsync(IEditDoctorRequest request);
        Task DeleteAsync(Guid Id);
    }
}
