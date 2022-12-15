using Assingment_3_A.Models;
using Assingment_3_A.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_A.Services.CRUD
{
    internal class Result
    {
        public static void CandidateResults()
        {
            Console.WriteLine("Give the id of the candidate you want to View");
            AppDBContext appDBContext = new AppDBContext();
            Candidate candi = appDBContext.Candidates.Find(int.Parse(Console.ReadLine()));
            var certResult = appDBContext.CertificateOfEachCandidates.Where(x => x.candidate.Id == candi.Id);

            Console.WriteLine("\n\n" + "First Name : " + candi.FirstName + "     Last Name : " + candi.LastName + "   Id : " + candi.Id + "\n\n\n");

            foreach (var c in certResult)
            {
                Console.WriteLine($"Certificate : , {c.certificate.Title}\n Score to Pass : {c.certificate.ScoreNeededToPass}\n");
                var certTopic = c.scorePerTopic;
                foreach (var a in certTopic)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine(c.Resualt + "\n\n");
            }
        }
    }
}

