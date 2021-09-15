using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bdpPruebaApi.Models;

namespace PasantiasApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<bdpPruebaApi.Models.Producto> Producto { get; set; }
        public DbSet<bdpPruebaApi.Models.Usuario> Usuario { get; set; }
        public DbSet<bdpPruebaApi.Models.Login> Login { get; set; }

        //public DbSet<Lider> Lider { get; set; }


    }
}
