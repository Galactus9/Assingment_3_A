using Assingment_3_A.Models;
using Assingment_3_A.Services.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_A.Services.CRUD
{
    internal class CanadidateCertificate
    {
        public static void CandidateCertificates()
        {
            Console.WriteLine("\n\nPlease type your ID");
            int canId = int.Parse(Console.ReadLine());
            AppDBContext appDBContext = new AppDBContext();
            Candidate candi = appDBContext.Candidates.Find(canId);
            var certResult = appDBContext.CertificateOfEachCandidates.Where(x => (x.candidate.Id == candi.Id) && (x.Resualt == "Pass")).Include(m=>m.certificate).ToList<CertificateOfEachCandidate>();

            Console.WriteLine("\nFirst Name : "  + candi.FirstName + "     Last Name : " + candi.LastName + "   Id : " + candi.Id +"\n\n\n");

            foreach (var c in certResult)
            {
                Console.WriteLine("\n\n" + "Certificate : " + c.certificate.Title + "\nScore : " + c.totalScore + "\nResult : " + c.Resualt);
            }
        }
    }
}
