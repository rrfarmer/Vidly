namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('John Smith', 1, 1, '8/26/1989 12:00:00 AM')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Mary Jane', 0, 1, '8/26/1989 12:00:00 AM')");
        }
        
        public override void Down()
        {
        }
    }
}
