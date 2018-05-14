namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendences", "ClassName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendences", "ClassName");
        }
    }
}
