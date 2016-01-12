namespace LewisList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdditional : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryMasterName", c => c.String());
            AddColumn("dbo.Posts", "Price", c => c.String());
            AddColumn("dbo.Posts", "PostalCode", c => c.String());
            AddColumn("dbo.Posts", "Telephone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Telephone");
            DropColumn("dbo.Posts", "PostalCode");
            DropColumn("dbo.Posts", "Price");
            DropColumn("dbo.Categories", "CategoryMasterName");
        }
    }
}
