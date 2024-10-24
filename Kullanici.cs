using System.ComponentModel.DataAnnotations;

namespace EBA_Kargo_Takip
{
    public class Kullanici
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Ad gereklidir.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad gereklidir.")]
        public string Soyad { get; set; }

        public Kullanici()
        {
            Id = 0;
            Email = string.Empty;
            Sifre = string.Empty;
            Ad = string.Empty;
            Soyad = string.Empty;
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad} ({Email})";
        }
    }
}