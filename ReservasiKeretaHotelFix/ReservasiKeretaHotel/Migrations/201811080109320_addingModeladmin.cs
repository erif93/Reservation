namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModeladmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        Createdate = c.DateTimeOffset(nullable: false, precision: 7),
                        Updatedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Deletedate = c.DateTimeOffset(nullable: false, precision: 7),
                        Isdelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
