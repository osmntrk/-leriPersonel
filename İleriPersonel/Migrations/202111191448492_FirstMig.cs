namespace İleriPersonel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SehirId = c.Int(nullable: false),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sehir", t => t.SehirId, cascadeDelete: true)
                .Index(t => t.SehirId);
            
            CreateTable(
                "dbo.Sehir",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Calısan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        IlceId = c.Int(nullable: false),
                        EgitimId = c.Int(nullable: false),
                        KapıNo = c.Int(nullable: false),
                        Cadde = c.String(),
                        Sokak = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Egitim", t => t.EgitimId, cascadeDelete: true)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .Index(t => t.IlceId)
                .Index(t => t.EgitimId);
            
            CreateTable(
                "dbo.Egitim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Egitmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unvan = c.String(),
                        Ad = c.String(),
                        Soyad = c.String(),
                        IlceId = c.Int(nullable: false),
                        EgitimId = c.Int(nullable: false),
                        KapıNo = c.Int(nullable: false),
                        Cadde = c.String(),
                        Sokak = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Egitim", t => t.EgitimId, cascadeDelete: true)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .Index(t => t.IlceId)
                .Index(t => t.EgitimId);
            
            CreateTable(
                "dbo.Ogrenci",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        IlceId = c.Int(nullable: false),
                        EgitimId = c.Int(nullable: false),
                        KapıNo = c.Int(nullable: false),
                        Cadde = c.String(),
                        Sokak = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Egitim", t => t.EgitimId, cascadeDelete: true)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .Index(t => t.IlceId)
                .Index(t => t.EgitimId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calısan", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Ogrenci", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Ogrenci", "EgitimId", "dbo.Egitim");
            DropForeignKey("dbo.Egitmen", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Egitmen", "EgitimId", "dbo.Egitim");
            DropForeignKey("dbo.Calısan", "EgitimId", "dbo.Egitim");
            DropForeignKey("dbo.Ilce", "SehirId", "dbo.Sehir");
            DropIndex("dbo.Ogrenci", new[] { "EgitimId" });
            DropIndex("dbo.Ogrenci", new[] { "IlceId" });
            DropIndex("dbo.Egitmen", new[] { "EgitimId" });
            DropIndex("dbo.Egitmen", new[] { "IlceId" });
            DropIndex("dbo.Calısan", new[] { "EgitimId" });
            DropIndex("dbo.Calısan", new[] { "IlceId" });
            DropIndex("dbo.Ilce", new[] { "SehirId" });
            DropTable("dbo.Ogrenci");
            DropTable("dbo.Egitmen");
            DropTable("dbo.Egitim");
            DropTable("dbo.Calısan");
            DropTable("dbo.Sehir");
            DropTable("dbo.Ilce");
        }
    }
}
