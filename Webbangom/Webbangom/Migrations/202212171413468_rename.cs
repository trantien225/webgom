namespace Webbangom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Binhs", "MaSP", c => c.String());
            AddColumn("dbo.Dias", "MaSP", c => c.String());
            DropColumn("dbo.Binhs", "Soluong");
            DropColumn("dbo.Dias", "Soluong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dias", "Soluong", c => c.String());
            AddColumn("dbo.Binhs", "Soluong", c => c.String());
            DropColumn("dbo.Dias", "MaSP");
            DropColumn("dbo.Binhs", "MaSP");
        }
    }
}
