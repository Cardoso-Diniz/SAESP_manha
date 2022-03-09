using Microsoft.EntityFrameworkCore;
using SAESP_manha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAESP_manha.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
                   : base(options)
        {
        }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<Perfis> Perfis { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
