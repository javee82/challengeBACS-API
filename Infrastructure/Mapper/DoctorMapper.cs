using Models.Data;
using Models.ViewModels.DoctorVM;
using Models.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapper
{
    public static class DoctorMapper
    {
        public static void Map(Doctor source, DoctorVM target)
        {
            target.DoctorId = source.DoctorId;
            target.Speciallity = (PersonEnum.MedicalSpeciallity)source.Speciallity;
            target.LicenseNumber = source.LicenseNumber;
            if (source.Person != null)
            {
                target.Person.FirstName = source.Person.FirstName;
                target.Person.LastName = source.Person.LastName;
                target.Person.PhoneNumber = source.Person.PhoneNumber;
                target.Person.DateOfBirth = source.Person.DateOfBirth;
                target.Person.DNI = source.Person.DNI;
            }
        }
    }
}
