namespace WpfApp_ogrenciOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sinif_eklendi_data_annotations_eklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sinifs",
                c => new
                    {
                        sinif_id = c.Int(nullable: false, identity: true),
                        seviye = c.Int(nullable: false),
                        sube = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.sinif_id);
            
            AddColumn("dbo.ogrencis", "SinifID", c => c.Int(nullable: false));
            AddColumn("dbo.ogrencis", "sinif_sinif_id", c => c.Int());
            CreateIndex("dbo.ogrencis", "sinif_sinif_id");
            AddForeignKey("dbo.ogrencis", "sinif_sinif_id", "dbo.sinifs", "sinif_id");
            DropColumn("dbo.ogrencis", "Sinif");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ogrencis", "Sinif", c => c.String(nullable: false));
            DropForeignKey("dbo.ogrencis", "sinif_sinif_id", "dbo.sinifs");
            DropIndex("dbo.ogrencis", new[] { "sinif_sinif_id" });
            DropColumn("dbo.ogrencis", "sinif_sinif_id");
            DropColumn("dbo.ogrencis", "SinifID");
            DropTable("dbo.sinifs");
        }
    }
}
