using System.ComponentModel.DataAnnotations;

namespace LibraryBook.Models
{
    public class Auteur 
    {
        [Key]
        public string? IdAuteur { get ; set ; }
        public string? Nom { get; set; } 
    }
}
