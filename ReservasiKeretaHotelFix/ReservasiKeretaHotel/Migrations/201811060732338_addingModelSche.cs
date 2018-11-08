namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelSche : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        information = c.String(),
                        departure = c.DateTime(nullable: false),
                        arrival = c.DateTime(nullable: false),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                        destinations_Id = c.Int(),
                        stations_Id = c.Int(),
                        trains_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stations", t => t.destinations_Id)
                .ForeignKey("dbo.Stations", t => t.stations_Id)
                .ForeignKey("dbo.Trains", t => t.trains_Id)
                .Index(t => t.destinations_Id)
                .Index(t => t.stations_Id)
                .Index(t => t.trains_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "trains_Id", "dbo.Trains");
            DropForeignKey("dbo.Schedules", "stations_Id", "dbo.Stations");
            DropForeignKey("dbo.Schedules", "destinations_Id", "dbo.Stations");
            DropIndex("dbo.Schedules", new[] { "trains_Id" });
            DropIndex("dbo.Schedules", new[] { "stations_Id" });
            DropIndex("dbo.Schedules", new[] { "destinations_Id" });
            DropTable("dbo.Schedules");
        }
    }
}
