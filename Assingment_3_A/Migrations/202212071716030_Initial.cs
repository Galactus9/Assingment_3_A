namespace Assingment_3_A.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MidleName = c.String(),
                        Gender = c.String(),
                        NativeLanguage = c.String(),
                        BirthDate = c.DateTime(),
                        PhotoIdType = c.String(),
                        PhotoIdNumber = c.String(),
                        PhotoIdIssueDate = c.DateTime(),
                        Email = c.String(),
                        Address = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        PostalCode = c.String(),
                        Country = c.String(),
                        LandlineNumber = c.String(),
                        MobileNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candidates");
        }
    }
}
