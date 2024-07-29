using Models.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Infrastructure.Enums.PersonEnum;

namespace Infrastructure.ViewModels.Request.Doctor
{
    public class CreateDoctorRequest : ICreateDoctorRequest
    {
        [Required]
        [Range(1, 10)]
        public MedicalSpeciallity Speciallity { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int DNI { get; set; }
    }
}
