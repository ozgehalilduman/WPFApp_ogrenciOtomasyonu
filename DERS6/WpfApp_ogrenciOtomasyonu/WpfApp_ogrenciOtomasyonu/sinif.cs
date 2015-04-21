using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp_ogrenciOtomasyonu
{
    public class sinif
    {
        [Key]
        public int sinif_id { get; set; }
        [Required(ErrorMessage = "")]
        [Range(1,12,ErrorMessage ="")]
        public int seviye { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(2,MinimumLength =1,ErrorMessage ="1 veya 2 karakter girilebilir daha fazlası girilemez")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="Rakam veya Özel karakterler girilemez")]
        public string sube { get; set; }
        [NotMapped]
        public string sinifad { get { return seviye + "-" + sube; } }

        public virtual List<ogrenci> sinifin_ogrencileri { get; set; }

    }
}
