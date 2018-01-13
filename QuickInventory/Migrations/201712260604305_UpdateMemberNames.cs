namespace QuickInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemberNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberTypes", "Name", c => c.String());
            Sql("UPDATE MemberTypes SET Name = 'Pay as you go' WHERE Id = 1");
            Sql("UPDATE MemberTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MemberTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MemberTypes SET Name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberTypes", "Name");
        }
    }
}
