namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelcollection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WagonTrains",
                c => new
                    {
                        Wagon_Id = c.Int(nullable: false),
                        Train_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Wagon_Id, t.Train_Id })
                .ForeignKey("dbo.Wagons", t => t.Wagon_Id, cascadeDelete: true)
                .ForeignKey("dbo.Trains", t => t.Train_Id, cascadeDelete: true)
                .Index(t => t.Wagon_Id)
                .Index(t => t.Train_Id);
            
            AddColumn("dbo.Trains", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.TrainWagons", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrainWagons", "Price", c => c.Double(nullable: false));
            DropForeignKey("dbo.WagonTrains", "Train_Id", "dbo.Trains");
            DropForeignKey("dbo.WagonTrains", "Wagon_Id", "dbo.Wagons");
            DropIndex("dbo.WagonTrains", new[] { "Train_Id" });
            DropIndex("dbo.WagonTrains", new[] { "Wagon_Id" });
            DropColumn("dbo.Trains", "Price");
            DropTable("dbo.WagonTrains");
        }
    }
}
