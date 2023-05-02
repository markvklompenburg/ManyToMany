using System;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;
using ManyToManyTest.Models;

namespace ManyToManyTest.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}

