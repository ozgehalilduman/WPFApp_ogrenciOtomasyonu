﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        //[RegularExpression(@"^[a-zA-Z'-'\s]{1,40}$", ErrorMessage = "Ad alanına Rakam veya Özel karakterler girilemez")]
        [Required(ErrorMessage = "AD DEGERİ GİRİLMEK ZORUNDA")]
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
        //[RegularExpression(@"^[a-zA-Z'-'\s]{1,40}$", ErrorMessage = "Soyad Alanına Rakam veya Özel karakterler girilemez")]
        [Required(ErrorMessage = "SOYAD DEGERİ GİRİLMEK ZORUNDA")]
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

        [Required(ErrorMessage ="SINIF DEGERİ GİRİLMEK ZORUNDA")]        
        public int SinifID{ get; set; }
        [ForeignKey("SinifID")]
        public virtual sinif sinif { get; set; }
    }
}
