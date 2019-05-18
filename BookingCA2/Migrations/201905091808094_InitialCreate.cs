namespace BookingCA2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booking",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        ClientID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        Booked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Client", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.Room", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.ClientID)
                .Index(t => t.RoomID);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false),
                        Insurance = c.Boolean(nullable: false),
                        GardaVetting = c.Boolean(nullable: false),
                        NoiseLevel = c.Int(nullable: false),
                        NumberPeople = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientID);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Teas = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Booking", "RoomID", "dbo.Room");
            DropForeignKey("dbo.Booking", "ClientID", "dbo.Client");
            DropIndex("dbo.Booking", new[] { "RoomID" });
            DropIndex("dbo.Booking", new[] { "ClientID" });
            DropTable("dbo.Room");
            DropTable("dbo.Client");
            DropTable("dbo.Booking");
        }
    }
}
