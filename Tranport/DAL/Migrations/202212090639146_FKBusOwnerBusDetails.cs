namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKBusOwnerBusDetails : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.BusDetails", "BusOwnerId");
            AddForeignKey("dbo.BusDetails", "BusOwnerId", "dbo.BusOwners", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BusDetails", "BusOwnerId", "dbo.BusOwners");
            DropIndex("dbo.BusDetails", new[] { "BusOwnerId" });
        }
    }
}
