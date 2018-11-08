namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelTrain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(),
                        Password = c.String(),
                        address = c.String(),
                        BirthOfDate = c.DateTime(nullable: false),
                        Handphone = c.Double(nullable: false),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        status = c.Boolean(nullable: false),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                        trainwagons_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TrainWagons", t => t.trainwagons_Id)
                .Index(t => t.trainwagons_Id);
            
            CreateTable(
                "dbo.TrainWagons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                        trains_Id = c.Int(),
                        wagons_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trains", t => t.trains_Id)
                .ForeignKey("dbo.Wagons", t => t.wagons_Id)
                .Index(t => t.trains_Id)
                .Index(t => t.wagons_Id);
            
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Wagons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DestinationStations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                        stations_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stations", t => t.stations_Id)
                .Index(t => t.stations_Id);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                        cities_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.cities_Id)
                .Index(t => t.cities_Id);
            
            CreateTable(
                "dbo.OriginStations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                        stations_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stations", t => t.stations_Id)
                .Index(t => t.stations_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OriginStations", "stations_Id", "dbo.Stations");
            DropForeignKey("dbo.DestinationStations", "stations_Id", "dbo.Stations");
            DropForeignKey("dbo.Stations", "cities_Id", "dbo.Cities");
            DropForeignKey("dbo.Chairs", "trainwagons_Id", "dbo.TrainWagons");
            DropForeignKey("dbo.TrainWagons", "wagons_Id", "dbo.Wagons");
            DropForeignKey("dbo.TrainWagons", "trains_Id", "dbo.Trains");
            DropIndex("dbo.OriginStations", new[] { "stations_Id" });
            DropIndex("dbo.Stations", new[] { "cities_Id" });
            DropIndex("dbo.DestinationStations", new[] { "stations_Id" });
            DropIndex("dbo.TrainWagons", new[] { "wagons_Id" });
            DropIndex("dbo.TrainWagons", new[] { "trains_Id" });
            DropIndex("dbo.Chairs", new[] { "trainwagons_Id" });
            DropTable("dbo.OriginStations");
            DropTable("dbo.Stations");
            DropTable("dbo.DestinationStations");
            DropTable("dbo.Cities");
            DropTable("dbo.Wagons");
            DropTable("dbo.Trains");
            DropTable("dbo.TrainWagons");
            DropTable("dbo.Chairs");
            DropTable("dbo.Accounts");
        }
    }
}
