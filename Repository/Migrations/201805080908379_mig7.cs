namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendences", "Class1", c => c.String());
            DropColumn("dbo.Attendences", "Class");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendences", "Class", c => c.String());
            DropColumn("dbo.Attendences", "Class1");
        }
    }
}
