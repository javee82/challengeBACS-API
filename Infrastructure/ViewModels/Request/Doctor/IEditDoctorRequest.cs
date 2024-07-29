using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ViewModels.Request.Doctor
{
    public interface IEditDoctorRequest : ICreateDoctorRequest
    {
        Guid Id { get; set; }
    }
}
