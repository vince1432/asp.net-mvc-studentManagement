namespace asp.net_mvc_studentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeg : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "g");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "g", c => c.Int(nullable: false));
        }
    }
}
