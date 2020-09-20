using blazor2.Data;
using blazor2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor2.Services
{
    public interface IBookServise
    {
        public IList<книга> get();
        public void add(книга новая_книга);
    }

    public class BookService : IBookServise
    {
        ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<книга> get()
        {
            return _context.книги.ToList();
        }

        public void add(книга новая_книга)
        {
            if (!String.IsNullOrEmpty(новая_книга.name) && !String.IsNullOrEmpty(новая_книга.author))
            {
                _context.книги.Add(новая_книга);
                 _context.SaveChanges();
            }            
        }
        
    }
}
