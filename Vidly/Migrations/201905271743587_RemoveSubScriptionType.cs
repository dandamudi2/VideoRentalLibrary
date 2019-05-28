namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSubScriptionType : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SubscriptionTypes", newName: "MemberShipTypes");
            DropForeignKey("dbo.Customers", "SubScriptionType_id", "dbo.SubscriptionTypes");
            DropIndex("dbo.Customers", new[] { "SubScriptionType_id" });
            DropColumn("dbo.Customers", "MemberShipTypeId");
            RenameColumn(table: "dbo.Customers", name: "SubScriptionType_id", newName: "MemberShipTypeId");
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipTypeId");
            AddForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte());
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Customers", name: "MemberShipTypeId", newName: "SubScriptionType_id");
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "SubScriptionType_id");
            AddForeignKey("dbo.Customers", "SubScriptionType_id", "dbo.SubscriptionTypes", "id");
            RenameTable(name: "dbo.MemberShipTypes", newName: "SubscriptionTypes");
        }
    }
}
