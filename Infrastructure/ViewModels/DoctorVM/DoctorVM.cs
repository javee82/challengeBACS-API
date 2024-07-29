using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ViewModels.Person;
using static Models.Infrastructure.Enums.PersonEnum;

namespace Models.ViewModels.DoctorVM
{
    public class DoctorVM
    {
        public Guid DoctorId { get; set; }
        public MedicalSpeciallity Speciallity { get; set; }
        public string LicenseNumber { get; set; }
        public PersonVM Person {  get; set; } = new PersonVM();
    }
}
