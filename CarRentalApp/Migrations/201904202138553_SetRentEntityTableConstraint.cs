using System.Data.Entity.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class SetRentEntityTableConstraint : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Rents");
            AddColumn("dbo.Bills", "Details", c => c.String());
            AddColumn("dbo.Bills", "RentID", c => c.String(nullable: false, maxLength: 8, fixedLength: true));
            AlterColumn("dbo.Rents", "DateEnd", c => c.DateTime());
            AddPrimaryKey("dbo.Rents", "RentId");
            CreateIndex("dbo.Bills", "RentID");
            CreateIndex("dbo.Rents", "CarId");
            CreateIndex("dbo.Rents", "ClientId");
            CreateIndex("dbo.Rents", "UserId");
            AddForeignKey("dbo.Bills", "RentID", "dbo.Rents", "RentId", cascadeDelete: true);
            AddForeignKey("dbo.Rents", "CarId", "dbo.Cars", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rents", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rents", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "UserId", "dbo.Users");
            DropForeignKey("dbo.Rents", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Rents", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Bills", "RentID", "dbo.Rents");
            DropIndex("dbo.Rents", new[] { "UserId" });
            DropIndex("dbo.Rents", new[] { "ClientId" });
            DropIndex("dbo.Rents", new[] { "CarId" });
            DropIndex("dbo.Bills", new[] { "RentID" });
            DropPrimaryKey("dbo.Rents");
            AlterColumn("dbo.Rents", "DateEnd", c => c.DateTime(nullable: false));
            DropColumn("dbo.Bills", "RentID");
            DropColumn("dbo.Bills", "Details");
            AddPrimaryKey("dbo.Rents", new[] { "ClientId", "CarId", "UserId", "RentId" });
        }
    }
}
