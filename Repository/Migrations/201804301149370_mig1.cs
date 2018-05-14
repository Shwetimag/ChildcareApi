namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            AddColumn("dbo.Participants", "Images", c => c.Binary());
            DropTable("dbo.Images");
        }
    }
}
