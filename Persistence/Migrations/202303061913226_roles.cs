namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roles : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetRoles", "enabled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "enabled", c => c.Boolean());
        }
    }
}
