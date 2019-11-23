namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dress_BoughtDate_ToNullAble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dresses", "BoughtDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dresses", "BoughtDate", c => c.DateTime(nullable: false));
        }
    }
}
