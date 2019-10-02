using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WifiMap.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Wifi> Wifies { get; set; }
        public DbSet<Person> Persones { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }
    }
}
