using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_A.Models
{
    internal class CandidateScorePerTopic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Score { get; set; }
        public Candidate candidate { get; set; }

    public override string ToString()
    {
        return $"Topic Title : {Title}\t Topic Score : {Score}";
    }
    }
}
