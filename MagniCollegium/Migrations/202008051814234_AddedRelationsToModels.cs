namespace MagniCollegium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelationsToModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Course_Id", c => c.Int());
            AddColumn("dbo.Students", "Subject_Id", c => c.Int());
            AddColumn("dbo.Subjects", "Course_Id", c => c.Int());
            CreateIndex("dbo.Students", "Course_Id");
            CreateIndex("dbo.Students", "Subject_Id");
            CreateIndex("dbo.Subjects", "Course_Id");
            AddForeignKey("dbo.Students", "Course_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.Students", "Subject_Id", "dbo.Subjects", "Id");
            AddForeignKey("dbo.Subjects", "Course_Id", "dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Students", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Subjects", new[] { "Course_Id" });
            DropIndex("dbo.Students", new[] { "Subject_Id" });
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropColumn("dbo.Subjects", "Course_Id");
            DropColumn("dbo.Students", "Subject_Id");
            DropColumn("dbo.Students", "Course_Id");
        }
    }
}
