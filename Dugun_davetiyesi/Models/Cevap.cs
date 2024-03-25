using System.ComponentModel.DataAnnotations;

namespace Dugun_davetiyesi.Models
{
    public class Cevap
    {
        [Required(ErrorMessage ="Lütfen ad alanını boş bırakmayınız !")]
        public string  Ad { get; set; }




        [Required(ErrorMessage = "Lütfen Soyad alanını boş bırakmayınız !")]
        public string SoyAd { get; set; }




        [Required(ErrorMessage = "Lütfen Email alanını boş bırakmayınız !")]
        [EmailAddress]//Email adresinin emaile uygunluğunu kontrol etmek için eklenen validationdur
        public string Email { get; set; }




        [Required(ErrorMessage = "Lütfen Telefon alanını boş bırakmayınız !")]
        public string Telefon { get; set; }



        [Required(ErrorMessage = "Lütfen bir seçim yapınız  !")]
        public bool? DuguneGelecekmi  { get; set; }
    }
}
