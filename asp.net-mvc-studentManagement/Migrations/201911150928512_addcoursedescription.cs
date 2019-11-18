namespace asp.net_mvc_studentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcoursedescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "g", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "g", c => c.Byte(nullable: false));
            DropColumn("dbo.Courses", "Description");
        }
    }
}
