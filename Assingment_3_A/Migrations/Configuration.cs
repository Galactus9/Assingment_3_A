namespace Assingment_3_A.Migrations
{
    using Assingment_3_A.Models;
    using Assingment_3_A.Services.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assingment_3_A.Services.Data.AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assingment_3_A.Services.Data.AppDBContext context)
        {
            // Add some Certificates
            try
            {
                if (context.Certificates.Count() == 0)
                {
                    AppDBContext appDBContext = new AppDBContext();
                    var listOfCertificateTipics1 = new List<CertificateTopics>();
                    listOfCertificateTipics1.Add(new CertificateTopics { Title = "1_Topic1", MaxScore = 25 });
                    listOfCertificateTipics1.Add(new CertificateTopics { Title = "1_Topic2", MaxScore = 25 });
                    listOfCertificateTipics1.Add(new CertificateTopics { Title = "1_Topic3", MaxScore = 25 });
                    listOfCertificateTipics1.Add(new CertificateTopics { Title = "1_Topic4", MaxScore = 25 });

                    Certificate certificate1 = new Certificate();
                    certificate1.Description = "DevOps";
                    certificate1.Title = "C#";
                    certificate1.CerificateTopics = listOfCertificateTipics1;
                    certificate1.ScoreNeededToPass = 60;

                    appDBContext.Certificates.Add(certificate1);
                    appDBContext.SaveChanges();


                    var listOfCertificateTipics2 = new List<CertificateTopics>();
                    listOfCertificateTipics2.Add(new CertificateTopics { Title = "2_Topic1", MaxScore = 20 });
                    listOfCertificateTipics2.Add(new CertificateTopics { Title = "2_Topic2", MaxScore = 20 });
                    listOfCertificateTipics2.Add(new CertificateTopics { Title = "2_Topic3", MaxScore = 20 });
                    listOfCertificateTipics2.Add(new CertificateTopics { Title = "2_Topic4", MaxScore = 20 });
                    listOfCertificateTipics2.Add(new CertificateTopics { Title = "2_Topic5", MaxScore = 20 });

                    Certificate certificate2 = new Certificate();
                    certificate2.Description = "DevOps"; ;
                    certificate2.Title = "Java";
                    certificate2.CerificateTopics = listOfCertificateTipics2;
                    certificate2.ScoreNeededToPass = 60;

                    appDBContext.Certificates.Add(certificate2);
                    appDBContext.SaveChanges();


                    var listOfCertificateTipics3 = new List<CertificateTopics>();
                    listOfCertificateTipics3.Add(new CertificateTopics { Title = "3_Topic1", MaxScore = 33 });
                    listOfCertificateTipics3.Add(new CertificateTopics { Title = "3_Topic2", MaxScore = 33 });
                    listOfCertificateTipics3.Add(new CertificateTopics { Title = "3_Topic3", MaxScore = 34 });

                    Certificate certificate3 = new Certificate();
                    certificate3.Description = "DevOps"; ;
                    certificate3.Title = "Python";
                    certificate3.CerificateTopics = listOfCertificateTipics3;
                    certificate3.ScoreNeededToPass = 60;

                    appDBContext.Certificates.Add(certificate3);
                    appDBContext.SaveChanges();


                    var listOfCertificateTipics4 = new List<CertificateTopics>();
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic1", MaxScore = 25 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic2", MaxScore = 25 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic3", MaxScore = 25 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic4", MaxScore = 5 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic5", MaxScore = 10 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic6", MaxScore = 10 });

                    Certificate certificate4 = new Certificate();
                    certificate4.Description = "DevOps"; ;
                    certificate4.Title = "C++";
                    certificate4.CerificateTopics = listOfCertificateTipics4;
                    certificate4.ScoreNeededToPass = 60;

                    appDBContext.Certificates.Add(certificate4);
                    appDBContext.SaveChanges();


                    var listOfCertificateTipics5 = new List<CertificateTopics>();
                    listOfCertificateTipics5.Add(new CertificateTopics { Title = "5_Topic1", MaxScore = 25 });
                    listOfCertificateTipics5.Add(new CertificateTopics { Title = "5_Topic2", MaxScore = 25 });
                    listOfCertificateTipics5.Add(new CertificateTopics { Title = "5_Topic3", MaxScore = 25 });
                    listOfCertificateTipics5.Add(new CertificateTopics { Title = "5_Topic4", MaxScore = 25 });

                    Certificate certificate5 = new Certificate();
                    certificate5.Description = "DevOps"; ;
                    certificate5.Title = "SQL";
                    certificate5.CerificateTopics = listOfCertificateTipics5;
                    certificate5.ScoreNeededToPass = 60;

                    appDBContext.Certificates.AddOrUpdate(certificate5);
                    appDBContext.SaveChanges();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Add some Candidates
            try
            {
                if (context.Candidates.Count() == 0)
                {
                    context.Candidates.Add(new Candidate("Darth", "Vader", "D@V"));
                    context.Candidates.Add(new Candidate("Legolas", "Greenleaf", "L@G"));
                    context.Candidates.Add(new Candidate("Jack", "Sparrow", "J@S"));
                    context.Candidates.Add(new Candidate("Mr.", "Been", "M@B"));
                    context.Candidates.Add(new Candidate("Han", "Solo", "H@S"));
                    context.Candidates.Add(new Candidate("Scrooge", "McDuck", "S@C"));
                    context.Candidates.Add(new Candidate("Indiana", "Jones", "I@J"));
                    context.Candidates.Add(new Candidate("Tony", "Stark", "D@V"));
                    context.Candidates.Add(new Candidate("Ash", "Ketcham", "A@K"));
                    context.Candidates.Add(new Candidate("Captain", "Kirk", "C@K"));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Add some CretificateExams
            try
            {
                //if (context.CertificateOfEachCandidates.Count() == 0)
                //{
                NewMethod(context);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        /// Problems Meny Prroblems much much Problems ---->>> Solve Them!!!!!!!
        private static void NewMethod(AppDBContext context)
        {
            List<CertificateOfEachCandidate> certificates = new List<CertificateOfEachCandidate>();
            certificates.AddRange((IEnumerable<CertificateOfEachCandidate>)context.Certificates.ToList());
            foreach(CertificateOfEachCandidate cert in certificates)
            {
                
            Random rnd = new Random();
            int num = rnd.Next(10, 22);
                {
                    var listOfCandidateScorePerTopic1 = new List<CandidateScorePerTopic>();
                    listOfCandidateScorePerTopic1.Add(new CandidateScorePerTopic { Title = "1_Topic1", Score = num });
                    listOfCandidateScorePerTopic1.Add(new CandidateScorePerTopic { Title = "1_Topic2", Score = num - 2 });
                    listOfCandidateScorePerTopic1.Add(new CandidateScorePerTopic { Title = "1_Topic3", Score = num + 3 });
                    listOfCandidateScorePerTopic1.Add(new CandidateScorePerTopic { Title = "1_Topic4", Score = num - 4 });

                    CertificateOfEachCandidate cert1 = new CertificateOfEachCandidate();
                    cert1.candidate = context.Candidates.Where(c => c.Id == 1).FirstOrDefault();
                    cert1.certificate = context.Certificates.Where(c => c.Id == 1).FirstOrDefault();
                    cert1.DateOfExamination = DateTime.Now;
                    cert1.ScoreReportDate = DateTime.Now;
                    cert1.scorePerTopic = listOfCandidateScorePerTopic1;
                    cert1.totalScore = listOfCandidateScorePerTopic1.Sum(x => x.Score);
                    if (cert1.totalScore >= cert1.certificate.ScoreNeededToPass)
                    {
                        cert1.Resualt = "Pass";
                    }
                    else
                    {
                        cert1.Resualt = "Fail";
                    }
                    context.CertificateOfEachCandidates.Add(cert1);
                    context.SaveChanges();
                    if (cert1.Resualt == "Fail")
                    {
                        NewMethod(context);
                    }
                }
            }
        }
    }
}
