using LibraryBook.Models;

namespace LibraryBook.Repository
{
    public interface IRepositoryLivre
    {
<<<<<<< HEAD
        List<Livre> GetAll();
        Livre GetById(int Id);
        void Add(Livre Livre);
        void UpdateById(int Id,Livre Livre);
        bool DeleteById(int Id);
=======
        List<Livre> getAll();
        Livre getById(int Id);

        void Add(Livre Livre);
        void Update(int Id,Livre Livre);
        bool Delete(int Id);
>>>>>>> 1b5da80d78c1004023578aaff9e121c4be2e25a2

    }
}
