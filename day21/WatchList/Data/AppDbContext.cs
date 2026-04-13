using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WatchList.Models;

namespace WatchList.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<WatchItem> WatchItems { get; set; }
    }
}
