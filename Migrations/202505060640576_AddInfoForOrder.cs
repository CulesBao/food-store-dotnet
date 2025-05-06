namespace FoodStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfoForOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CustomerName", c => c.String());
            AddColumn("dbo.Orders", "CustomerPhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "CustomerPhoneNumber");
            DropColumn("dbo.Orders", "CustomerName");
        }
    }
}
