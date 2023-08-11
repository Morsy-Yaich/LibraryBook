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

<<<<<<< HEAD
        public bool DeleteById(int Id)
=======
        public bool Delete(int Id)
>>>>>>> 1b5da80d78c1004023578aaff9e121c4be2e25a2
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public List<Livre> GetAll()
=======
        public List<Livre> getAll()
>>>>>>> 1b5da80d78c1004023578aaff9e121c4be2e25a2
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public Livre GetById(int Id)
=======
        public Livre getById(int Id)
>>>>>>> 1b5da80d78c1004023578aaff9e121c4be2e25a2
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public void UpdateById(int Id, Livre Livre)
=======
        public void Update(int Id, Livre Livre)
>>>>>>> 1b5da80d78c1004023578aaff9e121c4be2e25a2
        {
            throw new NotImplementedException();
        }
    }
}
