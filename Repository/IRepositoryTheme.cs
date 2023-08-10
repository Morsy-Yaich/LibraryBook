using LibraryBook.Models;

namespace LibraryBook.Repository
{
    public interface IRepositoryTheme
    {
        List<Theme> GetAll();
        Theme GetById(int ID);
        void Add(Theme Theme);
        void UpdateById(int Id, Theme Theme);
        bool DeleteById(int Id);

    }
}
