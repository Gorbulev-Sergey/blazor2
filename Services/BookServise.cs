using blazor2.Data;
using blazor2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor2.Services
{
    public interface IBookServise
    {
        public IList<книга> get();
        public Task<List<книга>> get_async();
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
            return  _context.книги.ToList();
        }

        public async Task<List<книга>> get_async()
        {
            return await _context.книги.ToListAsync();
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
