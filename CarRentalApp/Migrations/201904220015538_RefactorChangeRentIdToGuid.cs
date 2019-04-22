namespace CarRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorChangeRentIdToGuid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bills", "RentID", "dbo.Rents");
            DropIndex("dbo.Bills", new[] { "RentID" });
            DropPrimaryKey("dbo.Rents");
            AlterColumn("dbo.Bills", "RentID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Rents", "RentId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Rents", "RentId");
            CreateIndex("dbo.Bills", "RentID");
            AddForeignKey("dbo.Bills", "RentID", "dbo.Rents", "RentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "RentID", "dbo.Rents");
            DropIndex("dbo.Bills", new[] { "RentID" });
            DropPrimaryKey("dbo.Rents");
            AlterColumn("dbo.Rents", "RentId", c => c.String(nullable: false, maxLength: 8, fixedLength: true));
            AlterColumn("dbo.Bills", "RentID", c => c.String(nullable: false, maxLength: 8, fixedLength: true));
            AddPrimaryKey("dbo.Rents", "RentId");
            CreateIndex("dbo.Bills", "RentID");
            AddForeignKey("dbo.Bills", "RentID", "dbo.Rents", "RentId", cascadeDelete: true);
        }
    }
}
