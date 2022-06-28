using Core.Entites.Concrete;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Context
{
    public class LyricNetContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-K7STUD3\SQLEXPRESS;Database=LyricNet;Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
