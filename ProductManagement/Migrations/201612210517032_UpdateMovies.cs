namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreId = 1 WHERE Id=1");
            Sql("UPDATE Movies SET GenreId = 2, Genre = 'Action', DateAdded = '06/12/2010' WHERE Id=2");
            Sql("UPDATE Movies SET GenreId = 2, Genre = 'Action', ReleaseDate = '03/11/2009' , DateAdded = '06/12/2010' WHERE Id=3");
            Sql("UPDATE Movies SET GenreId = 3, Genre = 'Family' WHERE Id=4");
            Sql("UPDATE Movies SET GenreId = 4, Genre = 'Romantic', ReleaseDate = '03/11/2009', DateAdded = '06/12/2010' WHERE Id=5");
        }
        
        public override void Down()
        {
        }
    }
}
