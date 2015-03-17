using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_ogrenciOtomasyonu
{
    public class veriyapisi :DbContext
    {
        public DbSet<ogrenci> ogrenciler { get; set; }
    }
}
