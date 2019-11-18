namespace asp.net_mvc_studentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delCourseId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "g", c => c.Byte(nullable: false));
            DropColumn("dbo.Courses", "CourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "g");
        }
    }
}
