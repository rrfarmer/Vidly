namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDummyMovies : DbMigration
    {
        public override void Up()
        {
            var now = DateTime.Now;
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Hangover', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Die Hard', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('The Terminator', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Toy Story', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Titanic', '8/26/1989 12:00:00 AM', '8/26/1989 12:00:00 AM', 10, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
