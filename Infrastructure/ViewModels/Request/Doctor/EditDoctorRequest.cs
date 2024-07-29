using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ViewModels.Request.Doctor
{
    public class EditDoctorRequest : CreateDoctorRequest, IEditDoctorRequest
    {
        public Guid Id { get; set; }
    }
}
