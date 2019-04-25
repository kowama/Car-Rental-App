using System.Data.Entity.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class CarEntityTableConstraintConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "LicensePlate", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Cars", "Description", c => c.String(maxLength: 2048));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Description", c => c.String());
            AlterColumn("dbo.Cars", "LicensePlate", c => c.String());
        }
    }
}
