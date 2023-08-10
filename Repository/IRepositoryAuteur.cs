using LibraryBook.Models;

namespace LibraryBook.Repository
{
    public interface IRepositoryAuteur
    {
        List<Auteur> GetAll();
        Auteur GetById(int Id);
        void Add(Auteur Auteur);
        void UpdateById(int Id,Auteur Auteur);
        bool DeleteById(int Id);
    }
}
