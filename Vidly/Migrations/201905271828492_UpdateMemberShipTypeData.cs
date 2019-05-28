namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemberShipTypeData : DbMigration
    {
        public override void Up()
        {
            Sql("update dbo.MemberShipTypes set Name='Monthly' where id=1");
            Sql("update dbo.MemberShipTypes set Name='Quaterly' where id=2");
            Sql("update dbo.MemberShipTypes set Name='Half Yearly' where id=3");
        }
        
        public override void Down()
        {
        }
    }
}
