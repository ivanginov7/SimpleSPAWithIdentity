using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSPAWithIdentity.Data
{
    public class SimpleSPADbContext:IdentityDbContext
    {
        public SimpleSPADbContext(DbContextOptions<SimpleSPADbContext> options):base(options)
        {

        }

        public DbSet<Entry> Entries { get; set; }
    }
}
