using Microsoft.EntityFrameworkCore;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PatientRepository : IRepository<Patient, Guid>
    {
        private readonly AppDbContext _context;

        public PatientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Patient item) => await _context.Patients.AddAsync(item);

        public async Task DeleteAsync(Guid id)
        {
			var patient = await GetAsync(id);
			_context.People.Remove(patient.Person);
			_context.Patients.Remove(patient);
		}

        public async Task<IEnumerable<Patient>> GetAllAsync() => await _context.Patients.Include(p => p.Person).ToListAsync();

		public async Task<Patient> GetAsync(Guid id)
        {
			var patient = await _context.Patients.Include(p => p.Person).FirstOrDefaultAsync(d => d.PatientId == id);
			if (patient != null)
			{
				return patient;
			}
			throw new Exception("Patient not found");
		}

        public void UpdateAsync(Patient item)
        {
			_context.Attach(item);
			_context.Patients.Entry(item).State = EntityState.Modified;
		}
    }
}
