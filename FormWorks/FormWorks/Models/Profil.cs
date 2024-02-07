using System.ComponentModel.DataAnnotations;

namespace FormWorks.Models
{
    public class Profil
    {
        public int Id { get; set; }

        [StringLength(5, ErrorMessage = "Ürün adı en fazla 5 karakter olmalıdır.")]
        [Required(ErrorMessage = " Bu alan zorunludur .")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Lutfen email gir")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lutfen seçim yap")]
        public bool? exampleFormControlSelect1 { get; set; }

        [Required(ErrorMessage = "Lutfen foto koy")]
        public string? formFile { get; set; }
    }
}
