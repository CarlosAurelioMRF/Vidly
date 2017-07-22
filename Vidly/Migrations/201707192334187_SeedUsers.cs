namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@" INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'2634177f-f86a-4cf9-8391-8e2a9b41608c', N'guest@vidly.com', 0, N'APRY+jr8nrLzOYfSaIN+2YgbOktnezR4qYpeFIWRm406DdoxEo4xs3+68jQUOHSfVw==', N'02a9c3ed-df0a-405a-af45-b9a9ba0d45dc', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                   INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'511b0f21-413c-4351-9747-6fc97661a908', N'admin@vidly.com', 0, N'APXBkh0YNZuH6h3+65gcULKerKLK+e06KL35dLlPZncZmfdNst0og1hAIjTWpSVZbw==', N'a89374e2-0014-4d5e-a1b9-aa16c5969951', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                   INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'454387d1-0c6d-49f7-9be9-79eaafacd47d', N'CanManageMovies')
                   INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'511b0f21-413c-4351-9747-6fc97661a908', N'454387d1-0c6d-49f7-9be9-79eaafacd47d')
                ");
        }

    public override void Down()
        {
        }
    }
}
