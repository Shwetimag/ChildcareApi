namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendences", "Start_time", c => c.String());
            AddColumn("dbo.Attendences", "End_time", c => c.String());
            DropColumn("dbo.Attendences", "CheckIn");
            DropColumn("dbo.Attendences", "CheckOut");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendences", "CheckOut", c => c.String());
            AddColumn("dbo.Attendences", "CheckIn", c => c.String());
            DropColumn("dbo.Attendences", "End_time");
            DropColumn("dbo.Attendences", "Start_time");
        }
    }
}
