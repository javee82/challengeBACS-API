using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Doctor, Guid> Doctors { get; }
        public IRepository<Patient, Guid> Patients { get; }

        public Task Save();
    }
}
