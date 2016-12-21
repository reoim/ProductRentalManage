namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataTypeofGenre : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Movies", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
        }
    }
}
