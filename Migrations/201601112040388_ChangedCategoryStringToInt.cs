namespace LewisList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCategoryStringToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Category", c => c.Int(nullable: true, defaultValue: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Category", c => c.String());
        }
    }
}
