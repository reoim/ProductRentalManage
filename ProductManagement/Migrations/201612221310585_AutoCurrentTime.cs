namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutoCurrentTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTimeOffset(precision: 7));
        }
    }
}
