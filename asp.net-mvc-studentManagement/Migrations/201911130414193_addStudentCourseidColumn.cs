namespace asp.net_mvc_studentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudentCourseidColumn : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.StudentModels", "CourseId");
            AddForeignKey("dbo.StudentModels", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentModels", "CourseId", "dbo.Courses");
            DropIndex("dbo.StudentModels", new[] { "CourseId" });
        }
    }
}
