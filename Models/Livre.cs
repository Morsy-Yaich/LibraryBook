using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryBook.Models
{
    public class Livre
    {
        [Key]
        public int IdLivre { get; set; }
        public string? Titre { get; set; }
        public int AnnéePub { get; set; }
        public string? IdAuteur { get; set; }
        [ForeignKey("IdAuteur")]
        public int IdTheme { get; set; }
        [ForeignKey("IdTheme")]
        public string? FilePath { get; set; }
        public  DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
