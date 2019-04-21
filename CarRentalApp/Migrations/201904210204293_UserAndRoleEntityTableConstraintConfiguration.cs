namespace CarRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAndRoleEntityTableConstraintConfiguration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsersRoles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Users", "LastName", c => c.String(maxLength: 32));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 64));
            AlterColumn("dbo.Users", "Phone", c => c.String(maxLength: 16));
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.Roles", "Description", c => c.String(nullable: false, maxLength: 2048));
            CreateIndex("dbo.Users", "Username", unique: true);
            CreateIndex("dbo.Users", "Email", unique: true);
            CreateIndex("dbo.Roles", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UsersRoles", "UserId", "dbo.Users");
            DropIndex("dbo.UsersRoles", new[] { "RoleId" });
            DropIndex("dbo.UsersRoles", new[] { "UserId" });
            DropIndex("dbo.Roles", new[] { "Name" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            AlterColumn("dbo.Roles", "Description", c => c.String());
            AlterColumn("dbo.Roles", "Name", c => c.String());
            AlterColumn("dbo.Users", "Phone", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
            DropTable("dbo.UsersRoles");
        }
    }
}
