﻿namespace Assingment_3_A.Migrations
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
                    certificate1.CertificateTopics = listOfCertificateTipics1;
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
                    certificate2.CertificateTopics = listOfCertificateTipics2;
                    certificate2.ScoreNeededToPass = 60;

                    appDBContext.Certificates.Add(certificate2);
                    appDBContext.SaveChanges();


                    var listOfCertificateTipics3 = new List<CertificateTopics>();
                    listOfCertificateTipics3.Add(new CertificateTopics { Title = "3_Topic1", MaxScore = 33 });
                    listOfCertificateTipics3.Add(new CertificateTopics { Title = "3_Topic2", MaxScore = 40 });
                    listOfCertificateTipics3.Add(new CertificateTopics { Title = "3_Topic3", MaxScore = 27 });

                    Certificate certificate3 = new Certificate();
                    certificate3.Description = "DevOps"; ;
                    certificate3.Title = "Python";
                    certificate3.CertificateTopics = listOfCertificateTipics3;
                    certificate3.ScoreNeededToPass = 60;

                    appDBContext.Certificates.Add(certificate3);
                    appDBContext.SaveChanges();


                    var listOfCertificateTipics4 = new List<CertificateTopics>();
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic1", MaxScore = 30 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic2", MaxScore = 22 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic3", MaxScore = 20 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic4", MaxScore = 18 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic5", MaxScore = 23 });
                    listOfCertificateTipics4.Add(new CertificateTopics { Title = "4_Topic6", MaxScore = 17 });

                    Certificate certificate4 = new Certificate();
                    certificate4.Description = "DevOps"; ;
                    certificate4.Title = "C++";
                    certificate4.CertificateTopics = listOfCertificateTipics4;
                    certificate4.ScoreNeededToPass = 70;

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
                    certificate5.CertificateTopics = listOfCertificateTipics5;
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
                if (context.CertificateOfEachCandidates.Count() == 0)
                {
                    NewMethod();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.InnerException.Message);
            }

        }
        /// Problems Meny Prroblems much much Problems ---->>> Solve Them!!!!!!!
        /// 

        public static void NewMethod()
        {
            AppDBContext context = new AppDBContext();
            List<Candidate> candidates = new List<Candidate>();
            candidates.AddRange(context.Candidates.ToList());
            Random rnd = new Random();
            foreach (var candidate in candidates)
            {
                int whileTimes = rnd.Next(1, 5);

                do
                {
                    int num = rnd.Next(1, 5);
                    CertificateOfEachCandidate cert1 = new CertificateOfEachCandidate();
                    cert1.candidate = candidate;
                    cert1.certificate = context.Certificates.Where(c => c.Id == num).Include(c => c.CertificateTopics)
                .FirstOrDefault(); ;

                    var listOfCandidateScorePerTopic1 = new List<CandidateScorePerTopic>();
                    var certTopics = cert1.certificate.CertificateTopics.ToList();
                    foreach (var certTopic in certTopics)
                    {
                        num = rnd.Next(10, certTopic.MaxScore);
                        listOfCandidateScorePerTopic1.Add(new CandidateScorePerTopic { Title = certTopic.Title, Score = num, candidate = candidate });
                    }
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
                } while (context.CertificateOfEachCandidates.Where(c => c.candidate.Id == candidate.Id).Count() != whileTimes);
            }
        }

        //private static void NewMethod(AppDBContext context)
        //{
        //    List<Candidate> candidates = new List<Candidate>();
        //    candidates.AddRange(context.Candidates.ToList());
        //    Random rnd = new Random();
        //    foreach (var candidate in candidates)
        //    {
        //        int whileTimes = rnd.Next(1, 5);

        //        do
        //        {

        //            check if the candidate has allready pass this certificate


        //           var cert = context.CertificateOfEachCandidates
        //           .Where((c => c.candidate == candidate));
        //            var listttt = context.Entry(cert).Collection(c => c)


        //            int num = rnd.Next(1, 5);
        //            CertificateOfEachCandidate cert1 = new CertificateOfEachCandidate();
        //            cert1.candidate = candidate;
        //            cert1.certificate = context.Certificates.Find(num);
        //            var listOfCandidateScorePerTopic1 = new List<CandidateScorePerTopic>();
        //            var certTopics = cert1.certificate.CertificateTopics.ToList();
        //            foreach(var certTopic in certTopics)
        //            {
        //                num = rnd.Next(10, certTopic.MaxScore);
        //                listOfCandidateScorePerTopic1.Add(new CandidateScorePerTopic { Title = certTopic.Title, Score = num });
        //            }
        //            cert1.DateOfExamination = DateTime.Now;
        //            cert1.ScoreReportDate = DateTime.Now;
        //            cert1.scorePerTopic = listOfCandidateScorePerTopic1;
        //            cert1.totalScore = listOfCandidateScorePerTopic1.Sum(x => x.Score);
        //            if (cert1.totalScore >= cert1.certificate.ScoreNeededToPass)
        //            {
        //                cert1.Resualt = "Pass";
        //            }
        //            else
        //            {
        //                cert1.Resualt = "Fail";
        //            }
        //            context.CertificateOfEachCandidates.Add(cert1);
        //            context.SaveChanges();
        //            if (cert1.Resualt == "Fail")
        //            {
                        
        //            }

        //        } while (context.CertificateOfEachCandidates.Where(c => c.candidate.Id == candidate.Id).Count() != whileTimes);
        //    }
        //}
    }
}
