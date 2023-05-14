namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BusDetailsBusOwnerTAblesAddes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BusDetails", "BusOwnerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BusDetails", "BusOwnerId", c => c.String(nullable: false));
        }
    }
}
