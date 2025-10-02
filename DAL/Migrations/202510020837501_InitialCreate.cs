namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TravelRequestId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(),
                        Description = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TravelRequests", t => t.TravelRequestId, cascadeDelete: true)
                .Index(t => t.TravelRequestId);
            
            CreateTable(
                "dbo.TravelRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Destination = c.String(),
                        Purpose = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TravelRequests", "UserId", "dbo.Users");
            DropForeignKey("dbo.ExpenseClaims", "TravelRequestId", "dbo.TravelRequests");
            DropIndex("dbo.TravelRequests", new[] { "UserId" });
            DropIndex("dbo.ExpenseClaims", new[] { "TravelRequestId" });
            DropTable("dbo.Users");
            DropTable("dbo.TravelRequests");
            DropTable("dbo.ExpenseClaims");
        }
    }
}
