namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendences", "Class", c => c.String());
            DropColumn("dbo.Attendences", "ClassName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendences", "ClassName", c => c.String());
            DropColumn("dbo.Attendences", "Class");
        }
    }
}
