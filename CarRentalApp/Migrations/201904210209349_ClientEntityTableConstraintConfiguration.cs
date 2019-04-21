namespace CarRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientEntityTableConstraintConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "FirstName", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Clients", "LastName", c => c.String(maxLength: 32));
            AlterColumn("dbo.Clients", "Email", c => c.String(maxLength: 64));
            AlterColumn("dbo.Clients", "Phone", c => c.String(maxLength: 16));
            AlterColumn("dbo.Clients", "Address", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Address", c => c.String());
            AlterColumn("dbo.Clients", "Phone", c => c.String());
            AlterColumn("dbo.Clients", "Email", c => c.String());
            AlterColumn("dbo.Clients", "LastName", c => c.String());
            AlterColumn("dbo.Clients", "FirstName", c => c.String());
        }
    }
}
