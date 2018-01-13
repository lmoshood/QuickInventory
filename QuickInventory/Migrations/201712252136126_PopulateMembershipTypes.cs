namespace QuickInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MemberTypes ON");
            Sql("INSERT INTO MemberTypes (Id, SignUpFee, DurationMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MemberTypes (Id, SignUpFee, DurationMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MemberTypes (Id, SignUpFee, DurationMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            Sql("INSERT INTO MemberTypes (Id, SignUpFee, DurationMonths, DiscountRate) VALUES (4, 120, 5, 20)");
            Sql("SET IDENTITY_INSERT MemberTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
