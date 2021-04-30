namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2eae938d-1778-40f1-bf5a-f5849e7b9968', N'admin@farmeralts.com', 0, N'ALxnhTs0fTju1NdJUwwWaQsDfYR99lJFTve7VIP4+V9hoWtZShfcyBLhKVZvNHWUKw==', N'fe82b8f8-535e-40b5-bd4d-c749d5a0fc24', NULL, 0, 0, NULL, 1, 0, N'admin@farmeralts.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4cc1ca31-6009-4878-9471-c31da7c5b076', N'guest@farmeralts.com', 0, N'ADT+hM/zWh4KJyYtU5pxhvb0Gs4l5bPNJjpkD6d9g/U5VtcWK+loIUDnhDxXnzMrRg==', N'9080c798-08e0-4a4e-9eee-3971fd30fb92', NULL, 0, 0, NULL, 1, 0, N'guest@farmeralts.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ea1ee44d-a906-42f5-96d9-9171dbdacd46', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2eae938d-1778-40f1-bf5a-f5849e7b9968', N'ea1ee44d-a906-42f5-96d9-9171dbdacd46')

");
        }
        
        public override void Down()
        {
        }
    }
}
