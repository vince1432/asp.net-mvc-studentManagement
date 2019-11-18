namespace asp.net_mvc_studentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removestdid : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StudentModels", "StudentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentModels", "StudentId", c => c.Int(nullable: false));
        }
    }
}
