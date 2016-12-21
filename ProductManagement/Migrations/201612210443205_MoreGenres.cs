namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres ( Name ) VALUES ( 'Action' )");
            Sql("INSERT INTO Genres ( Name ) VALUES ( 'Family' )");
            Sql("INSERT INTO Genres ( Name ) VALUES ( 'Romantic' )");
            Sql("INSERT INTO Genres ( Name ) VALUES ( 'SF' )");
            Sql("INSERT INTO Genres ( Name ) VALUES ( 'Animation' )");
            Sql("INSERT INTO Genres ( Name ) VALUES ( 'Horror' )");
            Sql("INSERT INTO Genres ( Name ) VALUES ( 'Thriller' )");
        }
        
        public override void Down()
        {
        }
    }
}
