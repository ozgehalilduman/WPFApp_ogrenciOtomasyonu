namespace WpfApp_ogrenciOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ogrencis",
                c => new
                    {
                        ogrenciID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Sinif = c.String(),
                        Okulno = c.Int(nullable: false),
                        TcNo = c.String(),
                        Boy = c.Byte(nullable: false),
                        Kilo = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ogrenciID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ogrencis");
        }
    }
}
