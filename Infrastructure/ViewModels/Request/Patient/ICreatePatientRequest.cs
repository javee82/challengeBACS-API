using Infrastructure.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ViewModels.Request.Patient
{
    public interface ICreatePatientRequest : IPatient, IPerson
    {
    }
}
