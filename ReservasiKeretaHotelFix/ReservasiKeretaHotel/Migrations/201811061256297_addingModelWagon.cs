namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelWagon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Wagons", "trainclas_Id", c => c.Int());
            CreateIndex("dbo.Wagons", "trainclas_Id");
            AddForeignKey("dbo.Wagons", "trainclas_Id", "dbo.TrainClasses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wagons", "trainclas_Id", "dbo.TrainClasses");
            DropIndex("dbo.Wagons", new[] { "trainclas_Id" });
            DropColumn("dbo.Wagons", "trainclas_Id");
        }
    }
}
