namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Participants", "ZipCode", c => c.String());
            AlterColumn("dbo.Participants", "CellPhone", c => c.String());
            AlterColumn("dbo.Participants", "FCellPhone", c => c.String());
            AlterColumn("dbo.Participants", "GCellPhone", c => c.String());
            DropColumn("dbo.Participants", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Participants", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Participants", "GCellPhone", c => c.Long(nullable: false));
            AlterColumn("dbo.Participants", "FCellPhone", c => c.Long(nullable: false));
            AlterColumn("dbo.Participants", "CellPhone", c => c.Long(nullable: false));
            AlterColumn("dbo.Participants", "ZipCode", c => c.Int(nullable: false));
        }
    }
}
