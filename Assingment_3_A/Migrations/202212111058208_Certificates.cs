﻿namespace Assingment_3_A.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Certificates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CertificateOfEachCandidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfExamination = c.DateTime(nullable: false),
                        ScoreReportDate = c.DateTime(nullable: false),
                        totalScore = c.Int(nullable: false),
                        Resualt = c.String(),
                        candidate_Id = c.Int(),
                        certificate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.candidate_Id)
                .ForeignKey("dbo.Certificates", t => t.certificate_Id)
                .Index(t => t.candidate_Id)
                .Index(t => t.certificate_Id);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ScoreNeededToPass = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CertificateTopics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MaxScore = c.Int(nullable: false),
                        Certificate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Certificates", t => t.Certificate_Id)
                .Index(t => t.Certificate_Id);
            
            CreateTable(
                "dbo.CandidateScorePerTopics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Score = c.Int(nullable: false),
                        CertificateOfEachCandidate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CertificateOfEachCandidates", t => t.CertificateOfEachCandidate_Id)
                .Index(t => t.CertificateOfEachCandidate_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CandidateScorePerTopics", "CertificateOfEachCandidate_Id", "dbo.CertificateOfEachCandidates");
            DropForeignKey("dbo.CertificateOfEachCandidates", "certificate_Id", "dbo.Certificates");
            DropForeignKey("dbo.CertificateTopics", "Certificate_Id", "dbo.Certificates");
            DropForeignKey("dbo.CertificateOfEachCandidates", "candidate_Id", "dbo.Candidates");
            DropIndex("dbo.CandidateScorePerTopics", new[] { "CertificateOfEachCandidate_Id" });
            DropIndex("dbo.CertificateTopics", new[] { "Certificate_Id" });
            DropIndex("dbo.CertificateOfEachCandidates", new[] { "certificate_Id" });
            DropIndex("dbo.CertificateOfEachCandidates", new[] { "candidate_Id" });
            DropTable("dbo.CandidateScorePerTopics");
            DropTable("dbo.CertificateTopics");
            DropTable("dbo.Certificates");
            DropTable("dbo.CertificateOfEachCandidates");
        }
    }
}
