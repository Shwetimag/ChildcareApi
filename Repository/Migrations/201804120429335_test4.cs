namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Participants", "DateOfBirth", c => c.String());
            AlterColumn("dbo.Participants", "EnrollmentDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participants", "EnrollmentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Participants", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
