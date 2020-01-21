using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteApi2.Model;

namespace TesteApi2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options){}
        public DbSet<Evento> Eventos { get; set; }

    }
}
