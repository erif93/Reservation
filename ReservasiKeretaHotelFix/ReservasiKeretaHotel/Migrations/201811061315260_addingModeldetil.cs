namespace ReservasiKeretaHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModeldetil : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TrainWagons", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrainWagons", "Name", c => c.String());
        }
    }
}
