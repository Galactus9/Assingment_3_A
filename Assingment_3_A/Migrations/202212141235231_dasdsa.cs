namespace Assingment_3_A.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dasdsa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CandidateScorePerTopics", "candidate_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.CandidateScorePerTopics", "candidate_Id");
            AddForeignKey("dbo.CandidateScorePerTopics", "candidate_Id", "dbo.Candidates", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CandidateScorePerTopics", "candidate_Id", "dbo.Candidates");
            DropIndex("dbo.CandidateScorePerTopics", new[] { "candidate_Id" });
            DropColumn("dbo.CandidateScorePerTopics", "candidate_Id");
        }
    }
}
