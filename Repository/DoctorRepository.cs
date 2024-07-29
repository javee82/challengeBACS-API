using Microsoft.EntityFrameworkCore;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DoctorRepository : IRepository<Doctor, Guid>
    {
        private readonly AppDbContext _context;

        public DoctorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Doctor item) => await _context.Doctors.AddAsync(item);        

        public async Task DeleteAsync(Guid id)
        {
            var doctor = await GetAsync(id);            
            _context.People.Remove(doctor.Person);
            _context.Doctors.Remove(doctor);            
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync() => await _context.Doctors.Include(p => p.Person).ToListAsync();

        public async Task<Doctor> GetAsync(Guid id)
        {
            var doctor = await _context.Doctors.Include(p => p.Person).FirstOrDefaultAsync(d => d.DoctorId == id);
            if (doctor != null) 
            { 
                return doctor;
            }
            throw new Exception("Doctor not found");
        }

        public void UpdateAsync(Doctor item)
        {
            _context.Attach(item);
            _context.Doctors.Entry(item).State = EntityState.Modified;
        }
    }
}
