using Friont_To_Back.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Friont_To_Back.Dal
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
