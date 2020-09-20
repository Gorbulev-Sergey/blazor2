using System;
using System.Collections.Generic;
using System.Text;
using blazor2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blazor2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> toDoList { get; set; }
        public DbSet<книга> книги { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
