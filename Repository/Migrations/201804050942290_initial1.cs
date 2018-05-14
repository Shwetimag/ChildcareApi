namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addclasses",
                c => new
                    {
                        CId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        numberofstudents = c.Int(nullable: false),
                        enrolledstudents = c.Int(nullable: false),
                        minage = c.Int(nullable: false),
                        maxage = c.Int(nullable: false),
                        start = c.DateTime(nullable: false),
                        end = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addclasses");
        }
    }
}
