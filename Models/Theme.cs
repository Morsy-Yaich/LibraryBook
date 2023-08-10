using System.ComponentModel.DataAnnotations;

namespace LibraryBook.Models
{
    public class Theme
    {
        [Key]
        public int IdTheme { get; set; }
        public string Libelle { get; set; }
        public ICollection<Livre> Livres { get; } = new List<Livre>();

    }
}
