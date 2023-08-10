using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryBook.Models
{
    public class Section
    {
        [Key]
        public string? IdSection { get; set; }
        public  string? IdLivre { get; set; }
        [ForeignKey("IdLivre")]
        public string? Titre { get; set; }
        public string? RowContent { get; set; }
        public string? FilePath { get; set; }
    }
}
