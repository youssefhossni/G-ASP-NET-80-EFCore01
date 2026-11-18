using EFcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore.Context
{
    public class BookStoreContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet <Book>Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
