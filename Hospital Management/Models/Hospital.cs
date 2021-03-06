﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management.Models
{
    public class Hospital
    {
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string HospitalBranch { get; set;}
        public int ContactNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime OpeningDate { get; set; }
        public int Floors { get; set; }
    }
}
