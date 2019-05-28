namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemeberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubscriptionTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        SingUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "SubScriptionType_id", c => c.Byte());
            CreateIndex("dbo.Customers", "SubScriptionType_id");
            AddForeignKey("dbo.Customers", "SubScriptionType_id", "dbo.SubscriptionTypes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "SubScriptionType_id", "dbo.SubscriptionTypes");
            DropIndex("dbo.Customers", new[] { "SubScriptionType_id" });
            DropColumn("dbo.Customers", "SubScriptionType_id");
            DropColumn("dbo.Customers", "MemberShipTypeId");
            DropTable("dbo.SubscriptionTypes");
        }
    }
}
