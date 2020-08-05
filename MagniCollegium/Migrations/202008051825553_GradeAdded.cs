namespace MagniCollegium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GradeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        Student_Id = c.Int(),
                        Subject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.Subject_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Grades", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Grades", "Student_Id", "dbo.Students");
            DropIndex("dbo.Grades", new[] { "Subject_Id" });
            DropIndex("dbo.Grades", new[] { "Student_Id" });
            DropTable("dbo.Grades");
        }
    }
}
