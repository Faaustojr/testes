using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cointeste.Models;

namespace cointeste.Data
{
    public class cointesteContext : DbContext
    {
        public cointesteContext (DbContextOptions<cointesteContext> options)
            : base(options)
        {
        }

        public DbSet<cointeste.Models.Coin> Coin { get; set; } = default!;
    }
}
