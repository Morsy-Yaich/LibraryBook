using LibraryBook.Data;
using LibraryBook.Models;

namespace LibraryBook.Repository
{
    public class RepositoryAuteur : IRepositoryAuteur
    {
        private readonly AppDbContext _context;

        public RepositoryAuteur(AppDbContext context)
        {
            _context= context;
        }
        public void Add(Auteur Auteur)
        {
            throw new NotImplementedException();
        }
        public void GetAll(Auteur Auteur)
        {
            throw new NotImplementedException(); 
        }
        public bool DeleteById(int Id)
        { 
            throw new NotImplementedException(); 
        }
        public List<Auteur> GetAll()
        {
            throw new NotImplementedException (); 
        }
        public Auteur GetById(int Id) 
        { 
            throw new NotImplementedException (); 
        }
        public void UpdateById(int Id,Auteur Auteur)
        {
            throw new NotImplementedException () ;
        }

    }
}
