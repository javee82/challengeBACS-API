using Infrastructure.ViewModels.Request.Patient;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Infrastructure.Interfaces
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<Patient> GetAsync(Guid Id);
        Task<Patient> AddAsync(ICreatePatientRequest request);
        Task<Patient> UpdateAsync(IEditPatientRequest request);
        Task DeleteAsync(Guid Id);
    }
}
