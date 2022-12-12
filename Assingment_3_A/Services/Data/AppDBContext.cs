using Assingment_3_A.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_A.Services.Data
{
    internal class AppDBContext : DbContext
    {

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<CertificateOfEachCandidate> CertificateOfEachCandidates { get; set; }
        public AppDBContext() : base("Assingment3A")
        {

        }

    }
}
