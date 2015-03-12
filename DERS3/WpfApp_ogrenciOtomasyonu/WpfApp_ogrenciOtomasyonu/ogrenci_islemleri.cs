using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_ogrenciOtomasyonu
{
    /// <summary>
    /// ogrencilerle ilgili işlemlerin eylemlerin tanımlandığı kısım...
    /// </summary>
    class ogrenci_islemleri
    {
        /// <summary>
        /// Üzerinde işlem Yapılacak ogrencilistesi(ekleme-çıkarma-güncelleme-silme --CRUD--)
        /// </summary>
        ObservableCollection<ogrenci> ogr_lst = new ObservableCollection<ogrenci>();
        //cinsiyet kısmı için gerekli secenkleri oluşturuyorum
        List<char> cinsiyetler=new List<char>();
        //şimdilik baslangıç degerleri ekliyorum... Entity Framework kullanmaya başlayınca sileceğiz      
        /// <summary>
        /// YAPILANDIRICI METODUM
        /// </summary>
        public ogrenci_islemleri()
        {//beş baslangıc kaydı oluşturuyorum...
            ogr_lst.Add(new ogrenci() { Ad = "Ahmet Eren", Soyad = "Peker", Sinif = "TL-11", Okulno = 1100,TcNo="12345678901",Cinsiyet="E",Boy=170,Kilo=70 });
            ogr_lst.Add(new ogrenci() { Ad = "Mehmet", Soyad = "Acer", Sinif = "TL-11", Okulno = 1102, TcNo = "12345678902", Cinsiyet = "E", Boy = 171, Kilo = 70 });
            ogr_lst.Add(new ogrenci() { Ad = "Arif", Soyad = "Ceren", Sinif = "TL-11", Okulno = 1105, TcNo = "12345678903", Cinsiyet = "E", Boy = 170, Kilo = 70 });
            ogr_lst.Add(new ogrenci() { Ad = "Mert", Soyad = "Güven", Sinif = "TL-11", Okulno = 1106, TcNo = "12345678904", Cinsiyet = "E", Boy = 171, Kilo = 70 });
            ogr_lst.Add(new ogrenci() { Ad = "Yusuf", Soyad = "KOÇ", Sinif = "TL-11", Okulno = 1107, TcNo = "12345678905", Cinsiyet = "E", Boy = 170, Kilo = 70 });
            ogr_lst.Add(new ogrenci() { Ad = "Mustafa", Soyad = "BAÇ", Sinif = "TL-11", Okulno = 1108, TcNo = "12345678906", Cinsiyet = "E", Boy = 171, Kilo = 70 });
            ogr_lst.Add(new ogrenci() { Ad = "Kaan", Soyad = "Özgen", Sinif = "TL-11", Okulno = 1131, TcNo = "12345678907", Cinsiyet = "E", Boy = 170, Kilo = 70 });
            ogr_lst.Add(new ogrenci() { Ad = "Emre", Soyad = "Yıldız", Sinif = "TL-11", Okulno = 1134, TcNo = "12345678908", Cinsiyet = "E", Boy = 171, Kilo = 70 });
            ogr_lst.Add(new ogrenci() { Ad = "Saygın", Soyad = "Bakar", Sinif = "TL-11", Okulno = 1158, TcNo = "12345678909", Cinsiyet = "E", Boy = 170, Kilo = 70 });
            ogr_lst.Add(new ogrenci() { Ad = "Mehmet", Soyad = "Öz", Sinif = "TL-11", Okulno = 1101, TcNo = "12345678910", Cinsiyet = "E", Boy = 171, Kilo = 70 });

            cinsiyetler.Add('E');
            cinsiyetler.Add('K');
        }
        ///<summary>
        /// Tüm Öğrencilerin Listesini Geriye Döndüren Metodumuz 
        /// </summary>
        /// <returns>List<ogrenci> mevcut tum ogrencileri listeler</returns>
        public ObservableCollection<ogrenci> ogrenciListesi()
        {
            return ogr_lst;
        }
        ///<summary>
        /// Belirli bir Öğrencinin bilgilerini Geriye Döndüren Metodumuz 
        /// </summary>
        /// 
        /// <returns>List<ogrenci> mevcut tum ogrencileri listeler</returns>
        public List<ogrenci> ogrenciListesi(ogrenci ogr)
        {
            return (from o in ogr_lst where o==ogr select o).ToList() ;
        }
        public List<char> cinsiyetListesi()
        {
            return cinsiyetler;
        }
        ///<summary>
        /// Secilen Öğrenciyi silen Metodumuz 
        /// </summary>
        public void ogrenciSil(ogrenci ogr)
        {
            ogr_lst.Remove(ogr);
        }
        ///<summary>
        /// Yeni ogrenciyi kaynağa eklemeye yarar 
        /// </summary>
        public void ogrenciEkle(ogrenci ogr)
        {
            ogr_lst.Add(ogr);
        }
    }
}
