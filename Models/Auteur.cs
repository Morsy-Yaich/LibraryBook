using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace LibraryBook.Models
{
    public class Auteur 
    {
        [Key]
        public int IdAut { get ; set ; }
        public string Nom { get; set; }
        public ICollection<Livre> Livres { get;  } = new List<Livre>(); 

    }
}
