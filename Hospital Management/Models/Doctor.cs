using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public int ContactNumber { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Salary { get; set; }
        //Foreign Key
        public int HospitalID { get; set; }
        public Hospital Hospital_ID { get; set; }
    }
}
