namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            // Populate Movies
            var now = DateTime.Now;
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Hangover', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 13)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Die Hard', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 14)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Terminator', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 14)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Toy Story', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 15)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Titanic', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 16)");
        }
        
        public override void Down()
        {
        }
    }
}
