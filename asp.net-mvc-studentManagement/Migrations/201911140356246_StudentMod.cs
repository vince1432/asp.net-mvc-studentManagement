namespace asp.net_mvc_studentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentMod : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentModels", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.StudentModels", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.StudentModels", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentModels", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentModels", "LastName", c => c.String());
            AlterColumn("dbo.StudentModels", "FirstName", c => c.String());
        }
    }
}
