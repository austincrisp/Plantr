namespace Plantr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowAptNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Souls", "AptNumber", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Souls", "AptNumber", c => c.Int(nullable: false));
        }
    }
}
