namespace CarRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassificationEntityTableConstraintConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classifications", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Classifications", "Description", c => c.String(nullable: false, maxLength: 2048));
            CreateIndex("dbo.Classifications", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Classifications", new[] { "Name" });
            AlterColumn("dbo.Classifications", "Description", c => c.String());
            AlterColumn("dbo.Classifications", "Name", c => c.String());
        }
    }
}
