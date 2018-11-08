namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelkcc : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.admins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
