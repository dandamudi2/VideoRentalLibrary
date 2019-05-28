namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromptMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes(id,SignUpFee,DurationInMonths,DiscountRate) values(1,0,0,0)");
            Sql("INSERT INTO MemberShipTypes(id,SignUpFee,DurationInMonths,DiscountRate) values(2,30,1,10)");
            Sql("INSERT INTO MemberShipTypes(id,SignUpFee,DurationInMonths,DiscountRate) values(3,90,1,20)");

        }

        public override void Down()
        {
        }
    }
}
