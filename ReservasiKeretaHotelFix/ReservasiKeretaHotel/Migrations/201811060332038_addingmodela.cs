namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodela : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Regencies", "villages_Id", "dbo.Villages");
            DropForeignKey("dbo.Cities", "regencies_Id", "dbo.Regencies");
            DropForeignKey("dbo.Provinces", "cities_Id", "dbo.Cities");
            DropIndex("dbo.Cities", new[] { "regencies_Id" });
            DropIndex("dbo.Regencies", new[] { "villages_Id" });
            DropIndex("dbo.Provinces", new[] { "cities_Id" });
            AddColumn("dbo.Cities", "provinces_Id", c => c.Int());
            AddColumn("dbo.Regencies", "cities_Id", c => c.Int());
            AddColumn("dbo.Villages", "regencies_Id", c => c.Int());
            CreateIndex("dbo.Cities", "provinces_Id");
            CreateIndex("dbo.Regencies", "cities_Id");
            CreateIndex("dbo.Villages", "regencies_Id");
            AddForeignKey("dbo.Cities", "provinces_Id", "dbo.Provinces", "Id");
            AddForeignKey("dbo.Regencies", "cities_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Villages", "regencies_Id", "dbo.Regencies", "Id");
            DropColumn("dbo.Cities", "regencies_Id");
            DropColumn("dbo.Regencies", "villages_Id");
            DropColumn("dbo.Provinces", "cities_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Provinces", "cities_Id", c => c.Int());
            AddColumn("dbo.Regencies", "villages_Id", c => c.Int());
            AddColumn("dbo.Cities", "regencies_Id", c => c.Int());
            DropForeignKey("dbo.Villages", "regencies_Id", "dbo.Regencies");
            DropForeignKey("dbo.Regencies", "cities_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "provinces_Id", "dbo.Provinces");
            DropIndex("dbo.Villages", new[] { "regencies_Id" });
            DropIndex("dbo.Regencies", new[] { "cities_Id" });
            DropIndex("dbo.Cities", new[] { "provinces_Id" });
            DropColumn("dbo.Villages", "regencies_Id");
            DropColumn("dbo.Regencies", "cities_Id");
            DropColumn("dbo.Cities", "provinces_Id");
            CreateIndex("dbo.Provinces", "cities_Id");
            CreateIndex("dbo.Regencies", "villages_Id");
            CreateIndex("dbo.Cities", "regencies_Id");
            AddForeignKey("dbo.Provinces", "cities_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Cities", "regencies_Id", "dbo.Regencies", "Id");
            AddForeignKey("dbo.Regencies", "villages_Id", "dbo.Villages", "Id");
        }
    }
}
