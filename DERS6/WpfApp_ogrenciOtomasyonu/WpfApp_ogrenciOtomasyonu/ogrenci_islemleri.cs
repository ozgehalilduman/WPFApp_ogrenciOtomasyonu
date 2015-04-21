using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;//data annotions larda oluşturduğumuz hataları yakalamak için

namespace WpfApp_ogrenciOtomasyonu
{
    /// <summary>
    /// ogrencilerle ilgili işlemlerin eylemlerin tanımlandığı kısım...
    /// </summary>
    class ogrenci_islemleri
    {
        veriyapisi verikaynak = new veriyapisi();
        //cinsiyet kısmı için gerekli secenkleri oluşturuyorum
        ObservableCollection<string> cinsiyetler=new ObservableCollection<string>();
        //şimdilik baslangıç degerleri ekliyorum... Entity Framework kullanmaya başlayınca sileceğiz      
        /// <summary>
        /// YAPILANDIRICI METODUM
        /// </summary>
        public ogrenci_islemleri()
        {
            verikaynak.ogrenciler.ToList();//local kaynağı dolduruyorum....
            //beş baslangıc kaydı oluşturuyorum...   
            
            if(verikaynak.ogrenciler.Local.Count<1)
            {
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "AhmetEren", Soyad = "Peker", SinifID = 1, Okulno = 1100,TcNo="12345678901",Cinsiyet="E",Boy=170,Kilo=70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Mehmet", Soyad = "Acer", SinifID = 1, Okulno = 1102, TcNo = "12345678902", Cinsiyet = "E", Boy = 171, Kilo = 70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Arif", Soyad = "Ceren", SinifID = 1, Okulno = 1105, TcNo = "12345678903", Cinsiyet = "E", Boy = 170, Kilo = 70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Mert", Soyad = "Güven", SinifID = 1, Okulno = 1106, TcNo = "12345678904", Cinsiyet = "E", Boy = 171, Kilo = 70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Yusuf", Soyad = "KOÇ", SinifID = 1, Okulno = 1107, TcNo = "12345678905", Cinsiyet = "E", Boy = 170, Kilo = 70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Mustafa", Soyad = "BAÇ", SinifID = 1, Okulno = 1108, TcNo = "12345678906", Cinsiyet = "E", Boy = 171, Kilo = 70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Kaan", Soyad = "Özgen", SinifID = 1, Okulno = 1131, TcNo = "12345678907", Cinsiyet = "E", Boy = 170, Kilo = 70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Emre", Soyad = "Yıldız", SinifID = 1, Okulno = 1134, TcNo = "12345678908", Cinsiyet = "E", Boy = 171, Kilo = 70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Saygin", Soyad = "Bakar", SinifID = 1, Okulno = 1158, TcNo = "12345678909", Cinsiyet = "E", Boy = 170, Kilo = 70 });
                verikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "MehmetX", Soyad = "Öz", SinifID = 1, Okulno = 1101, TcNo = "12345678910", Cinsiyet = "E", Boy = 171, Kilo = 70 });  
            }
            verikaynak.siniflar.ToList();
            if (verikaynak.siniflar.Local.Count < 1)
            {
                verikaynak.siniflar.Local.Add(new sinif() { seviye = 11, sube = "T" });
                verikaynak.siniflar.Local.Add(new sinif() { seviye = 10, sube = "T" });
                verikaynak.siniflar.Local.Add(new sinif() { seviye = 12, sube = "T" });
                verikaynak.siniflar.Local.Add(new sinif() { seviye = 11, sube = "S" });
                verikaynak.siniflar.Local.Add(new sinif() { seviye = 10, sube = "S" });
                verikaynak.siniflar.Local.Add(new sinif() { seviye = 12, sube = "S" });
            }
            cinsiyetler.Add("E");
            cinsiyetler.Add("K");
            vt_guncelle();
        }
        ///<summary>
        /// Tüm Öğrencilerin Listesini Geriye Döndüren Metodumuz 
        /// </summary>
        /// <returns>List<ogrenci> mevcut tum ogrencileri listeler</returns>
        public ObservableCollection<ogrenci> ogrenciListesi()
        {
            return verikaynak.ogrenciler.Local;
        }
        public ObservableCollection<sinif> sinifListesi()
        {
            return verikaynak.siniflar.Local;
        }
        public ObservableCollection<ogrenci> ogrenciListesi(int snf)
        {
            var _ilgili_ogrler =  verikaynak.ogrenciler.Local.Where(s=>s.SinifID==snf).ToList();
            ObservableCollection<ogrenci> ilgili_ogrler = new ObservableCollection<ogrenci>(_ilgili_ogrler);
            return ilgili_ogrler;
        }
        public ObservableCollection<string> cinsiyetListesi()
        {
            return cinsiyetler;
        }
        ///<summary>
        /// Secilen Öğrenciyi silen Metodumuz 
        /// </summary>
        public void ogrenciSil(ogrenci ogr)
        {
            verikaynak.ogrenciler.Local.Remove(ogr);
            vt_guncelle();
        }
        ///<summary>
        /// Secilen Öğrenciyi silen Metodumuz 
        /// </summary>
        public void ogrenciSil(List<ogrenci> ogrler)
        {
            foreach(ogrenci ogr in ogrler)
            {
                verikaynak.ogrenciler.Local.Remove(ogr);
            }
            
            vt_guncelle();
        }
        ///<summary>
        /// Yeni ogrenciyi kaynağa eklemeye yarar 
        /// </summary>
        public string ogrenciEkle(ogrenci ogr)
        {
            verikaynak.ogrenciler.Local.Add(ogr);
            string sonuc=vt_guncelle();
            if (sonuc != "işlem başarılı")
            {//datagridde gozükmemesi için siliyorum
                verikaynak.ogrenciler.Local.Remove(ogr);
            }
            return sonuc;
        }
        public string vt_guncelle()
        {   //hata yakalama kullanıyorum...
            try
            {
                verikaynak.SaveChanges();
                return "işlem başarılı";
            }
            catch (DbEntityValidationException e)
            {
                List<DbValidationError> hatalar=e.EntityValidationErrors.First().ValidationErrors.ToList();
                string hataMsj="";
                foreach (DbValidationError hata in hatalar)
                {
                    hataMsj+=hata.ErrorMessage+"\n";
                }
                return hataMsj;
            }
        }
    }
}
