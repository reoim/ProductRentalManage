namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre = 'Comedy', DateAdded = '06/12/2010' WHERE Id=1");
           
        }
        
        public override void Down()
        {
        }
    }
}
