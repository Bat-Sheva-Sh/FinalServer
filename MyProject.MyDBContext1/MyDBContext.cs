using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;

namespace MyProject.MyDBContext1
{
    public class MyDBContext: DbContext, IContext
    {
        private const string ConnectionString = "Connectionstring";

        public DbSet<Child> Children { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyProjectDb;Trusted_Connection=True;");
        }

    }
}
