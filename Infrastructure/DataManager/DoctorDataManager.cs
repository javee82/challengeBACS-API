using Infrastructure.Interfaces.Models;
using Infrastructure.ViewModels.Request.Doctor;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataManager
{
    public class DoctorDataManager
    {

        public void SetValues(Doctor doctor, ICreateDoctorRequest request)
        {            
            doctor.LicenseNumber = request.LicenseNumber;
            doctor.Speciallity = (Models.Enums.PersonEnum.MedicalSpeciallity)request.Speciallity;
        }

        public void SetPerson(Doctor doctor, IPerson person)
        {
            doctor.Person = doctor.Person ?? new Person();
            doctor.Person.DateOfBirth = person.DateOfBirth;
            doctor.Person.DNI = person.DNI;
            doctor.Person.FirstName = person.FirstName;
            doctor.Person.LastName = person.LastName;
            doctor.Person.PhoneNumber = person.PhoneNumber;
            
        }
    }
}
