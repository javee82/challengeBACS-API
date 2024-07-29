using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        private DoctorRepository _doctor;
        private PatientRepository _patient;

        public IRepository<Doctor, Guid> Doctors
        {
            get
            {
                return _doctor ?? (_doctor = new DoctorRepository(_context));
            }
        }

        public IRepository<Patient, Guid> Patients
        {
            get
            {
                return _patient ?? (_patient = new PatientRepository(_context));
            }
        }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task Save()
        {            
            await _context.SaveChangesAsync();
        }
    }
}
