namespace SearchPersonDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Interests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        ProfessionId = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professions", t => t.ProfessionId, cascadeDelete: true)
                .Index(t => t.ProfessionId);
            
            CreateTable(
                "dbo.Professions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfessionName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interests", "Person_Id", "dbo.People");
            DropForeignKey("dbo.People", "ProfessionId", "dbo.Professions");
            DropIndex("dbo.People", new[] { "ProfessionId" });
            DropIndex("dbo.Interests", new[] { "Person_Id" });
            DropTable("dbo.Professions");
            DropTable("dbo.People");
            DropTable("dbo.Interests");
        }
    }
}
