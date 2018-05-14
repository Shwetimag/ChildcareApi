namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addclasses", "numberofstudents", c => c.String());
            AlterColumn("dbo.Addclasses", "enrolledstudents", c => c.String());
            AlterColumn("dbo.Addclasses", "minage", c => c.String());
            AlterColumn("dbo.Addclasses", "maxage", c => c.String());
            DropColumn("dbo.Addclasses", "start");
            DropColumn("dbo.Addclasses", "end");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addclasses", "end", c => c.DateTime(nullable: false));
            AddColumn("dbo.Addclasses", "start", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Addclasses", "maxage", c => c.Int(nullable: false));
            AlterColumn("dbo.Addclasses", "minage", c => c.Int(nullable: false));
            AlterColumn("dbo.Addclasses", "enrolledstudents", c => c.Int(nullable: false));
            AlterColumn("dbo.Addclasses", "numberofstudents", c => c.Int(nullable: false));
        }
    }
}
