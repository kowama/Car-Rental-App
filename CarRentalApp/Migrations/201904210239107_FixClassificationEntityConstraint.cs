namespace CarRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixClassificationEntityConstraint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "ClassificationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "ClassificationId");
            AddForeignKey("dbo.Cars", "ClassificationId", "dbo.Classifications", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ClassificationId", "dbo.Classifications");
            DropIndex("dbo.Cars", new[] { "ClassificationId" });
            DropColumn("dbo.Cars", "ClassificationId");
        }
    }
}
