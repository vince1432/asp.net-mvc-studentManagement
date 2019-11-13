namespace asp.net_mvc_studentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourses1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseCode", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "CourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "CourseCode");
        }
    }
}
