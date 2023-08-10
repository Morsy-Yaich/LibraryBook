using LibraryBook.Models;

namespace LibraryBook.Repository
{
    public interface IRepositoryLivre
    {
        List<Livre> getAll();
        Livre getById(int Id);

        void Add(Livre Livre);
        void Update(int Id,Livre Livre);
        bool Delete(int Id);

    }
}
