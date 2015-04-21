namespace WpfApp_ogrenciOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ogrencis",
                c => new
                    {
                        ogrenciID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Soyad = c.String(nullable: false),
                        Okulno = c.Int(nullable: false),
                        TcNo = c.String(),
                        Cinsiyet = c.String(),
                        Boy = c.Byte(nullable: false),
                        Kilo = c.Byte(nullable: false),
                        SinifID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ogrenciID)
                .ForeignKey("dbo.sinifs", t => t.SinifID, cascadeDelete: true)
                .Index(t => t.SinifID);
            
            CreateTable(
                "dbo.sinifs",
                c => new
                    {
                        sinif_id = c.Int(nullable: false, identity: true),
                        seviye = c.Int(nullable: false),
                        sube = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.sinif_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ogrencis", "SinifID", "dbo.sinifs");
            DropIndex("dbo.ogrencis", new[] { "SinifID" });
            DropTable("dbo.sinifs");
            DropTable("dbo.ogrencis");
        }
    }
}
