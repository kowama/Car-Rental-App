using System.Data.Entity.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class RefactorSomeEntityDataType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bills");
            AlterColumn("dbo.Bills", "BillNumber", c => c.Guid(nullable: false));
            AlterColumn("dbo.Bills", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Cars", "PricePerDay", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddPrimaryKey("dbo.Bills", "BillNumber");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bills");
            AlterColumn("dbo.Cars", "PricePerDay", c => c.Single(nullable: false));
            AlterColumn("dbo.Bills", "Amount", c => c.Single(nullable: false));
            AlterColumn("dbo.Bills", "BillNumber", c => c.String(nullable: false, maxLength: 8, fixedLength: true));
            AddPrimaryKey("dbo.Bills", "BillNumber");
        }
    }
}
