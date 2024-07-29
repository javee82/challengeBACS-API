using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ViewModels.Request.Patient
{
    public interface IEditPatientRequest : ICreatePatientRequest
    {
        Guid Id { get; set; }
    }
}
