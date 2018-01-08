namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCanManageCustomersRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'08fca2da-89f7-49bf-a046-7a44f8f999b8', N'manager@vidly.com', 0, N'AFVHOaYFyiWDOc/pObJ4DIhPsyDfsT2MxglmRvYgUqOSaKQOrXEJ0PtmtnnptIPlmg==', N'733f4ee4-cb14-4ced-85bf-9bfafdffc6ec', N'5551212', 0, 0, NULL, 1, 0, N'manager@vidly.com', N'102938')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b4f21afe-98cd-463f-bc55-7067c993a7c3', N'CanManageCustomers')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'08fca2da-89f7-49bf-a046-7a44f8f999b8', N'b4f21afe-98cd-463f-bc55-7067c993a7c3')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'64bf1599-6b2c-41ac-91cd-6cd3f8eb5e1c', N'b4f21afe-98cd-463f-bc55-7067c993a7c3')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
