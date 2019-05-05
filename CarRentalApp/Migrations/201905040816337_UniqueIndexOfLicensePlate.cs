using System.Data.Entity.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class UniqueIndexOfLicensePlate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "LicensePlate", c => c.String(nullable: false, maxLength: 32));
            CreateIndex("dbo.Cars", "LicensePlate", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cars", new[] { "LicensePlate" });
            AlterColumn("dbo.Cars", "LicensePlate", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
