namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Attendences", "CheckIn", c => c.String());
            AlterColumn("dbo.Attendences", "CheckOut", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Attendences", "CheckOut", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Attendences", "CheckIn", c => c.DateTime(nullable: false));
        }
    }
}
