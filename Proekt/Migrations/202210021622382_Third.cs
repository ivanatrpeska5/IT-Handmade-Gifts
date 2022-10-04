namespace Proekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Id", "dbo.Proizvodis");
            DropIndex("dbo.Orders", new[] { "Id" });
            DropPrimaryKey("dbo.Proizvodis");
            AlterColumn("dbo.Orders", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Proizvodis", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Proizvodis", "Id");
            CreateIndex("dbo.Orders", "Id");
            AddForeignKey("dbo.Orders", "Id", "dbo.Proizvodis", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Id", "dbo.Proizvodis");
            DropIndex("dbo.Orders", new[] { "Id" });
            DropPrimaryKey("dbo.Proizvodis");
            AlterColumn("dbo.Proizvodis", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Orders", "Id", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Proizvodis", "Id");
            CreateIndex("dbo.Orders", "Id");
            AddForeignKey("dbo.Orders", "Id", "dbo.Proizvodis", "Id");
        }
    }
}
