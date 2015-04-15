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
        veriyapisi ogrencikaynak = new veriyapisi();
        //cinsiyet kısmı için gerekli secenkleri oluşturuyorum
        ObservableCollection<string> cinsiyetler=new ObservableCollection<string>();
        //şimdilik baslangıç degerleri ekliyorum... Entity Framework kullanmaya başlayınca sileceğiz      
        /// <summary>
        /// YAPILANDIRICI METODUM
        /// </summary>
        public ogrenci_islemleri()
        {
            ogrencikaynak.ogrenciler.ToList();//local kaynağı dolduruyorum....
            //beş baslangıc kaydı oluşturuyorum...   
            
            if(ogrencikaynak.ogrenciler.Local.Count<1)
            {
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Ahmet Eren", Soyad = "Peker", Sinif = "TL-11", Okulno = 1100,TcNo="12345678901",Cinsiyet="E",Boy=170,Kilo=70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Mehmet", Soyad = "Acer", Sinif = "TL-11", Okulno = 1102, TcNo = "12345678902", Cinsiyet = "E", Boy = 171, Kilo = 70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Arif", Soyad = "Ceren", Sinif = "TL-11", Okulno = 1105, TcNo = "12345678903", Cinsiyet = "E", Boy = 170, Kilo = 70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Mert", Soyad = "Güven", Sinif = "TL-11", Okulno = 1106, TcNo = "12345678904", Cinsiyet = "E", Boy = 171, Kilo = 70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Yusuf", Soyad = "", Sinif = "TL-11", Okulno = 1107, TcNo = "12345678905", Cinsiyet = "E", Boy = 170, Kilo = 70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Mustafa", Soyad = "", Sinif = "TL-11", Okulno = 1108, TcNo = "12345678906", Cinsiyet = "E", Boy = 171, Kilo = 70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Kaan", Soyad = "Özgen", Sinif = "TL-11", Okulno = 1131, TcNo = "12345678907", Cinsiyet = "E", Boy = 170, Kilo = 70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Emre", Soyad = "Yıldız", Sinif = "TL-11", Okulno = 1134, TcNo = "12345678908", Cinsiyet = "E", Boy = 171, Kilo = 70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "Saygın", Soyad = "Bakar", Sinif = "TL-11", Okulno = 1158, TcNo = "12345678909", Cinsiyet = "E", Boy = 170, Kilo = 70 });
                ogrencikaynak.ogrenciler.Local.Add(new ogrenci() { Ad = "MehmetX", Soyad = "Öz", Sinif = "TL-11", Okulno = 1101, TcNo = "12345678910", Cinsiyet = "E", Boy = 171, Kilo = 70 });
         
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
            return ogrencikaynak.ogrenciler.Local;
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
            ogrencikaynak.ogrenciler.Local.Remove(ogr);
            vt_guncelle();
        }
        ///<summary>
        /// Secilen Öğrenciyi silen Metodumuz 
        /// </summary>
        public void ogrenciSil(List<ogrenci> ogrler)
        {
            foreach(ogrenci ogr in ogrler)
            {
                ogrencikaynak.ogrenciler.Local.Remove(ogr);
            }
            
            vt_guncelle();
        }
        ///<summary>
        /// Yeni ogrenciyi kaynağa eklemeye yarar 
        /// </summary>
        public string ogrenciEkle(ogrenci ogr)
        {
            ogrencikaynak.ogrenciler.Local.Add(ogr);
            string sonuc=vt_guncelle();
            if (sonuc != "işlem başarılı")
            {//datagridde gozükmemesi için siliyorum
                ogrencikaynak.ogrenciler.Local.Remove(ogr);
            }
            return sonuc;
        }
        public string vt_guncelle()
        {   //hata yakalama kullanıyorum...
            try
            {
                ogrencikaynak.SaveChanges();
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
