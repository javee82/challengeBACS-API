using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class Patient
    {
        public Guid PatientId { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string SocialWorkNumber { get; set; }
	}
}
