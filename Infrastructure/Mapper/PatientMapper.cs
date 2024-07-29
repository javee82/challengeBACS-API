using Models.Data;
using Models.ViewModels.PatientVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapper
{
	public class PatientMapper
	{
		public static void Map(Patient source, PatientVM target)
		{
			target.PatientId = source.PatientId;			
			target.SocialWorkNumber = source.SocialWorkNumber;
			if (source.Person != null)
			{
				target.Person.Age = source.Person.Age;
				target.Person.FirstName = source.Person.FirstName;
				target.Person.LastName = source.Person.LastName;
				target.Person.PhoneNumber = source.Person.PhoneNumber;
				target.Person.DateOfBirth = source.Person.DateOfBirth;
				target.Person.DNI = source.Person.DNI;
			}
		}
	}
}
