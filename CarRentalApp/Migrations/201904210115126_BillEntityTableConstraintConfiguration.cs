using System.Data.Entity.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class BillEntityTableConstraintConfiguration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bills");
            AddColumn("dbo.Bills", "BillNumber", c => c.String(nullable: false, maxLength: 8, fixedLength: true));
            AlterColumn("dbo.Bills", "Details", c => c.String(maxLength: 2048));
            AddPrimaryKey("dbo.Bills", "BillNumber");
            DropColumn("dbo.Bills", "Id");
            DropColumn("dbo.Cars", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "State", c => c.String());
            AddColumn("dbo.Bills", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Bills");
            AlterColumn("dbo.Bills", "Details", c => c.String());
            DropColumn("dbo.Bills", "BillNumber");
            AddPrimaryKey("dbo.Bills", "Id");
        }
    }
}
