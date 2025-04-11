using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUTO_Patient_Management_Software.Models;
using FUTO_Patient_Management_Software.Utilities;

namespace FUTO_Patient_Management_Software.Controllers
{
    public class PatientController
    {
        private readonly DatabaseHelper _db;

        public PatientController(DatabaseHelper db)
        {
            _db = db;
        }

        public void AddPatient(Patient patient)
        {
            string query = @"INSERT INTO Patients 
            (Surname, OtherNames, Address, PhoneNumber, DateOfBirth, Age, Sex, ReferredBy, Occupation, Hobbies) 
            VALUES (@Surname, @OtherNames, @Address, @PhoneNumber, @DateOfBirth, @Age, @Sex, @ReferredBy, @Occupation, @Hobbies)";

            _db.Execute(query, patient);
        }

        public List<Patient> GetAllPatients()
        {
            return _db.Query<Patient>("SELECT * FROM Patients");
        }
    }

    internal class PatientController
    {
    }
}
