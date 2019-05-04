namespace CarRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
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
