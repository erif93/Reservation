namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelNew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Regencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                        villages_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Villages", t => t.villages_Id)
                .Index(t => t.villages_Id);
            
            CreateTable(
                "dbo.Villages",
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
                "dbo.Provinces",
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
            
            AddColumn("dbo.Cities", "Name", c => c.String());
            AddColumn("dbo.Cities", "regencies_Id", c => c.Int());
            CreateIndex("dbo.Cities", "regencies_Id");
            AddForeignKey("dbo.Cities", "regencies_Id", "dbo.Regencies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Provinces", "cities_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "regencies_Id", "dbo.Regencies");
            DropForeignKey("dbo.Regencies", "villages_Id", "dbo.Villages");
            DropIndex("dbo.Provinces", new[] { "cities_Id" });
            DropIndex("dbo.Regencies", new[] { "villages_Id" });
            DropIndex("dbo.Cities", new[] { "regencies_Id" });
            DropColumn("dbo.Cities", "regencies_Id");
            DropColumn("dbo.Cities", "Name");
            DropTable("dbo.Provinces");
            DropTable("dbo.Villages");
            DropTable("dbo.Regencies");
        }
    }
}
