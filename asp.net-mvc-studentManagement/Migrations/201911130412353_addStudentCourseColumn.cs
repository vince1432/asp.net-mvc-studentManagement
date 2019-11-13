namespace asp.net_mvc_studentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudentCourseColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentModels", "CourseId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentModels", "CourseId");
        }
    }
}
