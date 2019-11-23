namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dresses",
                c => new
                    {
                        DressId = c.Int(nullable: false, identity: true),
                        Drescription = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OriginialCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BoughtDate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.DressId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderCreated = c.DateTime(nullable: false),
                        RenterName = c.String(nullable: false),
                        RenterMobile = c.String(nullable: false),
                        RenterAddress = c.String(nullable: false),
                        Source = c.String(nullable: false),
                        ShipDate = c.DateTime(),
                        ExpectedReturnDate = c.DateTime(),
                        Status = c.String(nullable: false),
                        Note = c.String(),
                        DressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Dresses", t => t.DressId, cascadeDelete: true)
                .Index(t => t.DressId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "DressId", "dbo.Dresses");
            DropIndex("dbo.Orders", new[] { "DressId" });
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Dresses");
        }
    }
}
