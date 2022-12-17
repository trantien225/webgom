namespace Webbangom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Amtras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Soluong = c.String(),
                        Gia = c.String(),
                        img = c.String(),
                        DepId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mains", t => t.DepId, cascadeDelete: true)
                .Index(t => t.DepId);
            
            CreateTable(
                "dbo.Mains",
                c => new
                    {
                        DepID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DepID);
            
            CreateTable(
                "dbo.Binhs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Soluong = c.String(),
                        Gia = c.String(),
                        img = c.String(),
                        DepId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mains", t => t.DepId, cascadeDelete: true)
                .Index(t => t.DepId);
            
            CreateTable(
                "dbo.Dias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Soluong = c.String(),
                        Gia = c.String(),
                        img = c.String(),
                        DepId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mains", t => t.DepId, cascadeDelete: true)
                .Index(t => t.DepId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dias", "DepId", "dbo.Mains");
            DropForeignKey("dbo.Binhs", "DepId", "dbo.Mains");
            DropForeignKey("dbo.Amtras", "DepId", "dbo.Mains");
            DropIndex("dbo.Dias", new[] { "DepId" });
            DropIndex("dbo.Binhs", new[] { "DepId" });
            DropIndex("dbo.Amtras", new[] { "DepId" });
            DropTable("dbo.Dias");
            DropTable("dbo.Binhs");
            DropTable("dbo.Mains");
            DropTable("dbo.Amtras");
        }
    }
}
