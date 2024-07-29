using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Enums.PersonEnum;

namespace Models.Data
{
    public class Doctor
    {
        public Guid DoctorId { get; set; } = Guid.NewGuid();
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public MedicalSpeciallity Speciallity { get; set; }
        public string LicenseNumber { get; set; }
    }
}
