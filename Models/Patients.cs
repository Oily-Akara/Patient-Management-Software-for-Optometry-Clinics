using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUTO_Patient_Management_Software.Models
{
    public class Patients
    {
        public int PatientID { get; set; }
        public required string Surname { get; set; }
        public required string OtherNames { get; set; }
        public required string Address { get; set; } // Added required modifier
        public required string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public required string Sex { get; set; } // Added required modifier
        public required string ReferredBy { get; set; }
        public required string Occupation { get; set; }
        public required string Hobbies { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    internal class Patient
    {
    }
}
