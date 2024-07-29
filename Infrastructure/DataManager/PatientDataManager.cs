using Infrastructure.Interfaces.Models;
using Infrastructure.ViewModels.Request.Patient;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataManager
{
    public class PatientDataManager
    {
        public void SetValues(Patient patient, ICreatePatientRequest request)
        {
            patient.SocialWorkNumber = request.SocialWorkNumber;
        }

        public void SetPerson(Patient patient, IPerson person)
        {
            patient.Person = patient.Person ?? new Person();
            patient.Person.DateOfBirth = person.DateOfBirth;
            patient.Person.DNI = person.DNI;
            patient.Person.FirstName = person.FirstName;
            patient.Person.LastName = person.LastName;
            patient.Person.PhoneNumber = person.PhoneNumber;
        }
    }
}
