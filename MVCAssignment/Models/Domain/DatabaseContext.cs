﻿using Microsoft.EntityFrameworkCore;

namespace MVCAssignment.Models.Domain
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        
        {

        
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
    }
}
