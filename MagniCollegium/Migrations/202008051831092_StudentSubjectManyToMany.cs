namespace MagniCollegium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentSubjectManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Subject_Id", "dbo.Subjects");
            DropIndex("dbo.Students", new[] { "Subject_Id" });
            CreateTable(
                "dbo.SubjectStudents",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.Student_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Subject_Id)
                .Index(t => t.Student_Id);
            
            DropColumn("dbo.Students", "Subject_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Subject_Id", c => c.Int());
            DropForeignKey("dbo.SubjectStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.SubjectStudents", "Subject_Id", "dbo.Subjects");
            DropIndex("dbo.SubjectStudents", new[] { "Student_Id" });
            DropIndex("dbo.SubjectStudents", new[] { "Subject_Id" });
            DropTable("dbo.SubjectStudents");
            CreateIndex("dbo.Students", "Subject_Id");
            AddForeignKey("dbo.Students", "Subject_Id", "dbo.Subjects", "Id");
        }
    }
}
