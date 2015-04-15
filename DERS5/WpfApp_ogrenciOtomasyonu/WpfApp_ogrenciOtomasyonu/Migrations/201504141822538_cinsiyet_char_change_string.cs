namespace WpfApp_ogrenciOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cinsiyet_char_change_string : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ogrencis", "Cinsiyet", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ogrencis", "Cinsiyet");
        }
    }
}
