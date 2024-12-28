using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ExemploDbContext : DbContext
    {
        public ExemploDbContext(DbContextOptions<ExemploDbContext> options) : base(options)
        {
        }
        public DbSet<Exemplo> Exemplos { get; set; }
    }
}
