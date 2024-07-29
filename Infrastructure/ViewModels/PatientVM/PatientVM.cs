using Models.ViewModels.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.PatientVM
{
    public class PatientVM
    {
        public Guid PatientId { get; set; }
        public string SocialWorkNumber { get; set; }        
        public PersonVM Person { get; set; } = new PersonVM();		
	}
}
