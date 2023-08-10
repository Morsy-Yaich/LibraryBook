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

        public bool DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Livre> GetAll()
        {
            throw new NotImplementedException();
        }

        public Livre GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(int Id, Livre Livre)
        {
            throw new NotImplementedException();
        }
    }
}
