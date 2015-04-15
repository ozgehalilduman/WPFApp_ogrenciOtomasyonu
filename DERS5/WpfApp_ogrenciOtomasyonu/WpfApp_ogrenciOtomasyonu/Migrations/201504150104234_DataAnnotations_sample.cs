namespace WpfApp_ogrenciOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations_sample : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ogrencis", "Ad", c => c.String(nullable: false));
            AlterColumn("dbo.ogrencis", "Soyad", c => c.String(nullable: false));
            AlterColumn("dbo.ogrencis", "Sinif", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ogrencis", "Sinif", c => c.String());
            AlterColumn("dbo.ogrencis", "Soyad", c => c.String());
            AlterColumn("dbo.ogrencis", "Ad", c => c.String());
        }
    }
}
