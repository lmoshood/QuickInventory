namespace QuickInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Int(nullable: false),
                        DurationMonths = c.Int(nullable: false),
                        DiscountRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberTypeId");
            AddForeignKey("dbo.Customers", "MemberTypeId", "dbo.MemberTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberTypeId", "dbo.MemberTypes");
            DropIndex("dbo.Customers", new[] { "MemberTypeId" });
            DropColumn("dbo.Customers", "MemberTypeId");
            DropTable("dbo.MemberTypes");
        }
    }
}
