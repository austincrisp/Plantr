namespace Plantr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedComments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Souls", "Comments", c => c.String());
            DropColumn("dbo.Souls", "wasVisited");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Souls", "wasVisited", c => c.Boolean(nullable: false));
            DropColumn("dbo.Souls", "Comments");
        }
    }
}
