﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_ogrenciOtomasyonu
{
    /// <summary>
    /// ogrencilerin temel propertylerinin-özelliklerinin tanımlandığı kısım
    /// </summary>
    class ogrenci
    {   
        //GET ve SET kullanımına örnek Veriyorum..
        //GET degişken degeri okunurken devreye girecek kodların yazıldığı kısım 
        //SET degişkene değer ataması yapılırken devreye girecek kodların yazıldığı kısım
        //bugün için get set ayarlamasını ad ve soyad alanlarının dışında kullanmayacağım
        //ama bu kısmı geliştireceğiz...
        private string ad;
        public string Ad {
            get { return ad.ToUpper(); }//Sınıfın Ad değeri küçük harfle girilmiş olsa bile,okunurken büyük harfe çevrilmesini sağlıyorum
            set { ad = value; }//Üzerinde kontrol saglayabilmek(işlem yapabilmek) için Ad a girilen degeri private ad a aktarıyorum...
        }
        private string soyad;
        public string Soyad {
            get { return soyad.ToUpper(); }
            set { soyad = value; }
        }
        public string Sinif { get; set; }
        public int Okulno { get; set; }
        public string TcNo { get; set; }
        public char Cinsiyet { get; set; }
        public byte Boy { get; set; }
        public byte Kilo { get; set; }
    }
}
