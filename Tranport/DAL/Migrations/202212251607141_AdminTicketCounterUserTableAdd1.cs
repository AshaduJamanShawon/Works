namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminTicketCounterUserTableAdd1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        age = c.Int(nullable: false),
                        email = c.String(nullable: false, maxLength: 50),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TicketCounters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusName = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        password = c.String(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        password = c.String(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.TicketCounters", "AdminId", "dbo.Admins");
            DropIndex("dbo.Users", new[] { "AdminId" });
            DropIndex("dbo.TicketCounters", new[] { "AdminId" });
            DropTable("dbo.Users");
            DropTable("dbo.TicketCounters");
            DropTable("dbo.Admins");
        }
    }
}
