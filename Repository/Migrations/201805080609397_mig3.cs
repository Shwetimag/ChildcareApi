namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addclasses", "numberofstudents", c => c.String());
            AddColumn("dbo.Addclasses", "enrolledstudents", c => c.String());
            AddColumn("dbo.Addclasses", "minage", c => c.String());
            AddColumn("dbo.Addclasses", "maxage", c => c.String());
            AddColumn("dbo.Addclasses", "start", c => c.String());
            AddColumn("dbo.Addclasses", "end", c => c.String());
            DropColumn("dbo.Addclasses", "Max_no_of_student");
            DropColumn("dbo.Addclasses", "Students_enrolled");
            DropColumn("dbo.Addclasses", "Min_age");
            DropColumn("dbo.Addclasses", "Max_age");
            DropColumn("dbo.Addclasses", "Start_time");
            DropColumn("dbo.Addclasses", "End_time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addclasses", "End_time", c => c.String());
            AddColumn("dbo.Addclasses", "Start_time", c => c.String());
            AddColumn("dbo.Addclasses", "Max_age", c => c.String());
            AddColumn("dbo.Addclasses", "Min_age", c => c.String());
            AddColumn("dbo.Addclasses", "Students_enrolled", c => c.String());
            AddColumn("dbo.Addclasses", "Max_no_of_student", c => c.String());
            DropColumn("dbo.Addclasses", "end");
            DropColumn("dbo.Addclasses", "start");
            DropColumn("dbo.Addclasses", "maxage");
            DropColumn("dbo.Addclasses", "minage");
            DropColumn("dbo.Addclasses", "enrolledstudents");
            DropColumn("dbo.Addclasses", "numberofstudents");
        }
    }
}
