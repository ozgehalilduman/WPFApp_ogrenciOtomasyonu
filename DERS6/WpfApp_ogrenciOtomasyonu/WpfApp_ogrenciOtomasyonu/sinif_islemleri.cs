using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp_ogrenciOtomasyonu
{
    class sinif_islemleri
    {
        veriyapisi sinifkaynak = new veriyapisi();
        public sinif_islemleri()
        {
            sinifkaynak.siniflar.ToList();
            if (sinifkaynak.siniflar.Local.Count < 1)
            {
                sinifkaynak.siniflar.Local.Add(new sinif() { seviye = 11, sube = "T" });
                sinifkaynak.siniflar.Local.Add(new sinif() { seviye = 10, sube = "T" });
                sinifkaynak.siniflar.Local.Add(new sinif() { seviye = 12, sube = "T" });
                sinifkaynak.siniflar.Local.Add(new sinif() { seviye = 11, sube = "S" });
                sinifkaynak.siniflar.Local.Add(new sinif() { seviye = 10, sube = "S" });
                sinifkaynak.siniflar.Local.Add(new sinif() { seviye = 12, sube = "S" });
            }
            vt_guncelle();
        }
        public ObservableCollection<sinif> sinifListesi()
        {
            return sinifkaynak.siniflar.Local;
        }
        public void sinifSil()
        {
        }
        public void sinifEkle()
        {
        }
        public void vt_guncelle()
        {
            sinifkaynak.SaveChanges();
        }
    }
}
