using System.ComponentModel.DataAnnotations;

namespace LibraryBook.Models
{
    public class Theme
    {
        [Key]
        public string? IdTheme { get; set; }
        public string? Libelle { get; set; }
    }
}
