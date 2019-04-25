namespace CarRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewPropertiesToClientsUsersCars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Name", c => c.String());
            AddColumn("dbo.Cars", "CarImage", c => c.Binary());
            AddColumn("dbo.Clients", "Cin", c => c.String(nullable: false, maxLength: 32));
            AddColumn("dbo.Users", "Cin", c => c.String(nullable: false, maxLength: 32));
            CreateIndex("dbo.Clients", "Cin", unique: true);
            CreateIndex("dbo.Users", "Cin", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Cin" });
            DropIndex("dbo.Clients", new[] { "Cin" });
            DropColumn("dbo.Users", "Cin");
            DropColumn("dbo.Clients", "Cin");
            DropColumn("dbo.Cars", "CarImage");
            DropColumn("dbo.Cars", "Name");
        }
    }
}
