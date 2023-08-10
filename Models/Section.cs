using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryBook.Models
{
    public class Section
    {
        [Key]
        public int IdSection { get; set; }
        public int IdLivre { get; set; }
        public Livre Livre { get; set; }
        public string Titre { get; set; }
        public string RowContent { get; set; }
        public string FilePath { get; set; }
    }
}
