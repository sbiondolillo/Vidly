namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'64bf1599-6b2c-41ac-91cd-6cd3f8eb5e1c', N'admin@vidly.com', 0, N'AOrCFCwtkgw5wfMVMQxV/m1HFWsx4fuzgCA/V+Yj5SkP1eq3HTs+2fwYDumxTINWpA==', N'31f856af-fccd-4fbb-8370-f6878ef9bb51', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fc7ed138-5a37-4587-a77c-bca045232056', N'guest@vidly.com', 0, N'AKhOSiD9R0CPgy1o0AZguK3COPl5V5tQEaEo+lBuZ9faEFLZyatJAHrzK8gF5rQ2qA==', N'63888334-dc3a-4a8f-9484-903b8bdf3992', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'00c2883f-878d-4cfd-9ee1-f84b622694b0', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'64bf1599-6b2c-41ac-91cd-6cd3f8eb5e1c', N'00c2883f-878d-4cfd-9ee1-f84b622694b0')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
