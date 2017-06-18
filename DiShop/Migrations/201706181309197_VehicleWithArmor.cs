namespace DiShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VehicleWithArmor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicle", "ArmorId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicle", "ArmorId");
        }
    }
}
