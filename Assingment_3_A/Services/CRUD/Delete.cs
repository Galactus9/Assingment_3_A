using Assingment_3_A.Models;
using Assingment_3_A.Services.Data;
using System;
using System.Collections.Generic;
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
            AppDBContext appDBContext = new AppDBContext();
            Candidate obj = appDBContext.Candidates.Find(int.Parse(Console.ReadLine()));
            CertificateOfEachCandidate obj2 = appDBContext.CertificateOfEachCandidates.Where(x => x.candidate.Id == obj.Id).FirstOrDefault();
            appDBContext.CertificateOfEachCandidates.Remove(obj2);
            appDBContext.SaveChanges();
            appDBContext.Candidates.Remove(obj);
            appDBContext.SaveChanges();
        }
    }
}
