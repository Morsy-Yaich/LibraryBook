using LibraryBook.Models;

namespace LibraryBook.Repository
{
    public interface IRepositoryLivre
    {
        List<Livre> GetAll();
        Livre GetById(int Id);
        void Add(Livre Livre);
        void UpdateById(int Id,Livre Livre);
        bool DeleteById(int Id);
    }
}
