using Assingment_3_A.Models;
using Assingment_3_A.Services.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment_3_A.Services.CRUD
{
    internal class Delete
    {
        public static void DeleteCandidate()
        {
            Console.WriteLine("Please type the id of the candidate you want to Delete");
            int id = int.Parse(Console.ReadLine());
            AppDBContext appDBContext = new AppDBContext();
            Candidate obj = appDBContext.Candidates.Find(id);

            //var cert = appDBContext.Certificates
            //    .Where(c => c.Id == 1).Include(c => c.CertificateTopics)
            //    .FirstOrDefault();
            //Console.WriteLine(cert.CertificateTopics);
            //foreach (var a in cert.CertificateTopics)
            //{
            //    Console.WriteLine(a);

            var cert = appDBContext.CertificateOfEachCandidates
                .Where(c => c.candidate.Id == id).Include  (c => c.scorePerTopic);
            foreach (var score in cert.Include(c=>c.scorePerTopic))
            {
            Console.WriteLine(score);

            }
            //appDBContext.Candidates.Remove(obj);
            //appDBContext.SaveChanges();

        }
    }
}
