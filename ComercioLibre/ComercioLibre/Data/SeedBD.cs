using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqToDB;
using System.Threading.Tasks;
using ComercioLibre.Data.Entities;

namespace ComercioLibre.Data
{
    public class SeedBD
    {

        private readonly DataContext _dataContext;

        public SeedBD(DataContext context)
        {
            _dataContext = context;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckClienteAsync();
            await CheckCategoriaAsync();
            await CheckTiendaAsync();

        }

        private async Task CheckClienteAsync()
        {
            if (!_dataContext.Clientes.Any())
            {
                _dataContext.Clientes.Add(new Cliente
                {
                    Nombre = "OSCAR",
                    Telefono = "691996563",
                });

                _dataContext.Clientes.Add(new Cliente
                {
                    Nombre = "PRIMI",
                    Telefono="691997550"
                });

                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckCategoriaAsync()
        {
            if (!_dataContext.Categorias.Any())
            {
                _dataContext.Categorias.Add(new Categoria
                {
                    NombreCategoria = "PELUQUERIA",
                });

                _dataContext.Categorias.Add(new Categoria
                {
                    NombreCategoria = "TIENDA ROPA",
                });

                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckTiendaAsync()
        {
            if (!_dataContext.Tiendas.Any())
            {
                _dataContext.Tiendas.Add(new Tienda
                {
                    Nombre = "MODAS GALERIA",
                    Telefono = "968123456",
                    CategoriaId=1,
                    PaginaWeb="www.modasgaleria.com",
                    Comentario="ROPA DE MODA AL MEJOR PRECIO"

                });

                _dataContext.Tiendas.Add(new Tienda
                {
                    Nombre = "PELUQUERIA CALVO",
                    Telefono = "968654321",
                    CategoriaId = 1,
                    PaginaWeb = "",
                    Comentario = "CORTE DE PELO Y ARREGLO DE BARBA"
                });

                await _dataContext.SaveChangesAsync();
            }
        }


    }
}
