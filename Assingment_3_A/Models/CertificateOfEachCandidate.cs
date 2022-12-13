using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Assingment_3_A.Models
{
    internal class CertificateOfEachCandidate
    {
        public int Id { get; set; }
        public Candidate candidate { get; set; }
        public Certificate certificate { get; set; }
        public DateTime DateOfExamination { get; set; }
        public DateTime ScoreReportDate { get; set; }
        public ICollection<CandidateScorePerTopic> scorePerTopic { get; set; }
        public int totalScore { get; set; }
        public string Resualt { get; set; }

    }
}
