using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_A.Models
{
    internal class Certificate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<CertificateTopics> CertificateTopics { get; set; }
        public int ScoreNeededToPass { get; set; }
    }


}
