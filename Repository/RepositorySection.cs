using LibraryBook.Data;
using LibraryBook.Models;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;

namespace LibraryBook.Repository
{
    public class RepositorySection : IRepositorySection
    {
        private readonly AppDbContext _context;
        public RepositorySection(AppDbContext context)
        {
            _context = context;
        }
        public List<Section> GetAll()
        {
            throw new NotImplementedException();
        }
        public Section GetById(int Id)
        {
            throw new NotImplementedException();
        }
        public void UpdateByID(int Id,Section Section)
        {
            throw new NotImplementedException();
        }
        public bool DeleteById(int ID)
        {
            throw new NotImplementedException();
        }
        public void Add(Section Section)
        {
            throw new NotImplementedException();
        }
    }
    

}

