using LibraryBook.Data;
using LibraryBook.Models;

namespace LibraryBook.Repository
{
    public class RepositoryLivre : IRepositoryLivre
    {
        private readonly AppDbContext _context;
        public RepositoryLivre(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Livre Livre)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Livre> getAll()
        {
            throw new NotImplementedException();
        }

        public Livre getById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Livre Livre)
        {
            throw new NotImplementedException();
        }
    }
}
