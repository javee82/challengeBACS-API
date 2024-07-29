﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ViewModels.Request.Patient
{
    public class EditPatientRequest : CreatePatientRequest, IEditPatientRequest
    {
        public Guid Id { get; set; }
    }
}