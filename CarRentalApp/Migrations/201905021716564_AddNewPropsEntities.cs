using System.Data.Entity.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class AddNewPropsEntities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "NextDrainDate", c => c.DateTime());
            AddColumn("dbo.Cars", "PurchaseDate", c => c.DateTime());
            AddColumn("dbo.Clients", "DriverLicense", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "DriverLicense");
            DropColumn("dbo.Cars", "PurchaseDate");
            DropColumn("dbo.Cars", "NextDrainDate");
        }
    }
}
