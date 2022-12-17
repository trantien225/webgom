namespace Webbangom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mains", "img", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mains", "img");
        }
    }
}
