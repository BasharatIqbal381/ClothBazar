namespace ClothBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Description", c => c.String());
            AddColumn("dbo.Products", "Description", c => c.String());
            DropColumn("dbo.Categories", "NDescription");
            DropColumn("dbo.Products", "NDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "NDescription", c => c.String());
            AddColumn("dbo.Categories", "NDescription", c => c.String());
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Categories", "Description");
        }
    }
}
