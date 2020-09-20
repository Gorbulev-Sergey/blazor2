using blazor2.Data;
using blazor2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor2.Services
{
    public interface IToDoListService
    {
        Task<List<ToDo>> Get();
        Task<ToDo> Get(int id);
        Task<ToDo> Add(ToDo toDo);
        Task<ToDo> Update(ToDo toDo);
        Task<ToDo> Delete(int id);
    }

    public class ToDoListService : IToDoListService
    {
        private readonly ApplicationDbContext _context;

        public ToDoListService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ToDo>> Get()
        {
            return await _context.toDoList.ToListAsync();
        }

        public async Task<ToDo> Get(int id)
        {
            var toDo = await _context.toDoList.FindAsync(id);
            return toDo;
        }

        public async Task<ToDo> Add(ToDo toDo)
        {
            _context.toDoList.Add(toDo);
            await _context.SaveChangesAsync();
            return toDo;
        }
        
        public async Task<ToDo> Update(ToDo toDo)
        {
            _context.Entry(toDo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return toDo;
        }

        public async Task<ToDo> Delete(int id)
        {
            var toDo = await _context.toDoList.FindAsync(id);
            _context.toDoList.Remove(toDo);
            await _context.SaveChangesAsync();
            return toDo;
        }        

        
    }
}
