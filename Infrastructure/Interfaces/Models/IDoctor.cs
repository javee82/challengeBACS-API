using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Infrastructure.Enums.PersonEnum;


namespace Infrastructure.Interfaces.Models
{
    public interface IDoctor
    {
        public MedicalSpeciallity Speciallity { get; set; }
        public string LicenseNumber { get; set; }
    }
}
