namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Participants", "Images", c => c.Binary());
            DropTable("dbo.Images");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Images = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Participants", "Images");
        }
    }
}
