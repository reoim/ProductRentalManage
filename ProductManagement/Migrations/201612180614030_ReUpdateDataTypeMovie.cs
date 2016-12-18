namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReUpdateDataTypeMovie : DbMigration
    {
        public override void Up()
        {
            
            AlterColumn("dbo.Movies", "Stock", c => c.Int(nullable: true));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTimeOffset(nullable: true));
        }

        public override void Down()
        {
            
            AlterColumn("dbo.Movies", "Stock", c => c.Int());
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTimeOffset());
        }
    }
}
