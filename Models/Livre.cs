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
        public int IdAut { get; set; }
        public Auteur Auteur { get; set; }
        public int IdTheme { get; set; }
        public Theme Theme { get; set; }  
        public string? FilePath { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public  DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedAt { get; set; }
        public ICollection<Section> Sections { get; } = new List<Section>();

    }
}
