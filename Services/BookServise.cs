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
        Task<List<книга>> get();
        Task<книга> add(книга новая_книга);
    }

    public class BookService : IBookServise
    {
        ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<книга>> get()
        {
            return await _context.книги.ToListAsync();
        }

        public async Task<книга> add(книга новая_книга)
        {
            if (!String.IsNullOrEmpty(новая_книга.name) && !String.IsNullOrEmpty(новая_книга.author))
            {
                _context.книги.Add(новая_книга);
                await _context.SaveChangesAsync();
            }
            return новая_книга;
        }
        
    }
}
