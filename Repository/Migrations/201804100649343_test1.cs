namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addclasses", "start", c => c.DateTime(nullable: false));
            AddColumn("dbo.Addclasses", "end", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addclasses", "end");
            DropColumn("dbo.Addclasses", "start");
        }
    }
}
