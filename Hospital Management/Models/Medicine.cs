using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management.Models
{
    
    public class Medicine
    {
        [Key]
        public string MedicineName { get; set; }
        public int Cost { get; set; }
        public DateTime ExpiryDate { get; set; }
        //Foreign Key
        public int HospitalID { get; set; }
        public Hospital Hospital_ID { get; set; }
        
    }
}
