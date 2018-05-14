namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addclasses", "start", c => c.String());
            AlterColumn("dbo.Addclasses", "end", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addclasses", "end", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Addclasses", "start", c => c.DateTime(nullable: false));
        }
    }
}
