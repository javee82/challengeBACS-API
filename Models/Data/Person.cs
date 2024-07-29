using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DNI { get; set; }

		public int Age => CalculateAge();

		private int CalculateAge()
		{
			var today = DateTime.Today;
			var age = today.Year - DateOfBirth.Year;
				if (DateOfBirth.Date > today.AddYears(-age)) age--;			
			return age;
		}
	}
}
