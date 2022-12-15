using Assingment_3_A.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_A.Services.Data
{
    internal class AppDBContext : DbContext
    {

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<CertificateOfEachCandidate> CertificateOfEachCandidates { get; set; }
        //public virtual DbSet<CandidateScorePerTopic> CandidateScorePerTopic { get; set; }
        public AppDBContext() : base("Assingment3A")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CertificateOfEachCandidate>().HasRequired<Candidate>(c => c.candidate).WithMany().WillCascadeOnDelete(true);
            modelBuilder.Entity<CandidateScorePerTopic>().HasRequired<Candidate>(c => c.candidate).WithMany().WillCascadeOnDelete(true);
        }


    }
}
