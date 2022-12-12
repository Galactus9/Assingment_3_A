using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_A.Models
{
    internal class Candidate
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string MidleName { get; set; }
        public string Gender { get; set;}
        public string NativeLanguage { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhotoIdType { get; set; }
        public string PhotoIdNumber { get; set;}
        public DateTime PhotoIdIssueDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string LandlineNumber { get; set; }
        public string MobileNumber { get; set; }


        public Candidate(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            MidleName = "-";
            Gender = "-";
            NativeLanguage = "-";
            BirthDate = DateTime.Now;
            PhotoIdType = "-";
            PhotoIdNumber = "-";
            PhotoIdIssueDate = DateTime.Now;
            Email = email;
            Address = "Spiti tou";
            Region = "Earth";
            MobileNumber = "69xxxxxxxx";
        }

            public Candidate ()
            {

            }

        public override string ToString()
        {
            return $"FirstName : {FirstName}\t LastName : {LastName}\t ID : {Id}";
        }
    }
}
