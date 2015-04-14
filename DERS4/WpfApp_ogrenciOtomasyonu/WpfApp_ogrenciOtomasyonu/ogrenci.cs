using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_ogrenciOtomasyonu
{
    /// <summary>
    /// ogrencilerin temel propertylerinin-özelliklerinin tanımlandığı kısım
    /// </summary>
    public class ogrenci
    {
        //GET ve SET kullanımına örnek Veriyorum..
        //GET degişken degeri okunurken devreye girecek kodların yazıldığı kısım 
        //SET degişkene değer ataması yapılırken devreye girecek kodların yazıldığı kısım
        //bugün için get set ayarlamasını ad ve soyad alanlarının dışında kullanmayacağım
        //ama bu kısmı geliştireceğiz...
        public int ogrenciID { get; set; }
        private string ad;
        public string Ad {
            get {
                    if (ad != null)
                    {
                        return ad.ToUpper();
                    }
                    else
                    {
                        return ad;
                    }                    
                }//Sınıfın Ad değeri küçük harfle girilmiş olsa bile,okunurken büyük harfe çevrilmesini sağlıyorum
            set { ad = value; }//Üzerinde kontrol saglayabilmek(işlem yapabilmek) için Ad a girilen degeri private ad a aktarıyorum...
        }
        private string soyad;
        public string Soyad {
            get {
                    if (soyad != null)
                    {
                        return soyad.ToUpper();
                    }
                    else
                    {
                        return soyad;
                    }
            }
            set { soyad = value; }
        }
        public string Sinif { get; set; }
        public int Okulno { get; set; }
        private string tcno;
        public string TcNo {
            get {
                    if (tcno != null)
                    {
                        if (tcno.Length == 11)
                        {
                            return tcno;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    
                }
            set
                {
                    tcno = value;
                }

        }
        public string Cinsiyet { get; set; }
        public byte Boy { get; set; }
        public byte Kilo { get; set; }
    }
}
