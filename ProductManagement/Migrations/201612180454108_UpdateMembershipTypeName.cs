namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName='Pay as You Go' WHERE DurationInMonths=0");
            Sql("UPDATE MembershipTypes SET MembershipName='Monthly' WHERE DurationInMonths=1");
            Sql("UPDATE MembershipTypes SET MembershipName='3 Month' WHERE DurationInMonths=3");
            Sql("UPDATE MembershipTypes SET MembershipName='Annually' WHERE DurationInMonths=12");
        }
        
        public override void Down()
        {
        }
    }
}
