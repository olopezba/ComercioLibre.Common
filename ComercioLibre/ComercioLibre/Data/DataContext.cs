using ComercioLibre.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ComercioLibre.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Tienda> Tiendas { get; set; }

        public DbSet<CitaPrevia> CitaPrevias { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
