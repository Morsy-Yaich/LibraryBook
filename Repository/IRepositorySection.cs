using LibraryBook.Data;
using LibraryBook.Models;

namespace LibraryBook.Repository
{
    public interface IRepositorySection 
    {
        List <Section> GetAll();
        Section GetById(int Id);
        void UpdateByID(int Id, Section Section);
        bool DeleteById(int Id);
        void Add(Section Section);
    }
}
