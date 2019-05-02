namespace CarRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneDataTypeRefactor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Phone", c => c.String(maxLength: 32));
            AlterColumn("dbo.Users", "Phone", c => c.String(maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Phone", c => c.String(maxLength: 16));
            AlterColumn("dbo.Clients", "Phone", c => c.String(maxLength: 16));
        }
    }
}
