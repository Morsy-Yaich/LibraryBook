using LibraryBook.Data;
using LibraryBook.Models;
using Microsoft.IdentityModel.Tokens;

namespace LibraryBook.Repository
{
    public class RepositoryTheme : IRepositoryTheme
    {
        private readonly AppDbContext _context;
        public RepositoryTheme(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Theme Theme)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Theme> GetAll()
        {
            throw new NotImplementedException();
        }

        public Theme GetById(int ID)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(int Id, Theme Theme)
        {
            throw new NotImplementedException();
        }
    }
}
