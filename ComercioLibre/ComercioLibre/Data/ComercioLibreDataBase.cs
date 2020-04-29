using ComercioLibre.Data.Entities;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComercioLibre.Data
{
    public class ComercioLibreDataBase
    {
        private readonly SQLiteConnection _database;

        public ComercioLibreDataBase(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            CrearTablaBBDD();
        }

        public void ComprobarVersion()
        {

            CrearRegistrosBBDD();

        }
        private void CrearRegistrosBBDD()
        {
            List<Categoria> listaCategorias = GetAllCategoria();
            if (listaCategorias.Count() == 0)
            {
                List<Categoria> lista = new List<Categoria>(){
                    new Categoria()
                {
                    NombreCategoria = "ROPA"
                },
                new Categoria
                {
                    NombreCategoria = "PELUQUERIA",
                }
                };

                foreach (Categoria item in lista)
                {
                    App.DataBase.SaveCategoria(item);
                }
            }

            List<Tienda> listaTiendas = GetAllTienda();
            if (listaTiendas.Count == 0)
            {
                List<Tienda> lista = new List<Tienda>(){
                    new Tienda()
                {
                        Nombre="GALERIA MODAS",
                        Telefono="968123456",
                        CategoriaId=1,
                        Comentario="VENDEMOS TODAS LAS TALLAS",
                        PaginaWeb="www.galeriasmodas.com"
                },
                new Tienda
                {
                   Nombre="GALERIA MODAS",
                        Telefono="968123456",
                        CategoriaId=2,
                        Comentario="CORTAMOS EL PELO Y ARREGLAMOS BARBAS",
                        PaginaWeb=""
                }

                };

                foreach (Tienda item in lista)
                {
                    App.DataBase.SaveTienda(item);
                }
            }

            List<Cliente> listaClientes = GetAllCliente();
            if (listaClientes.Count == 0)
            {
                List<Cliente> lista = new List<Cliente>(){
                    new Cliente()
                {
                    Nombre="OSCAR",
                    Telefono="691996563"
                },
                new Cliente
                {
                   Nombre="PEPE",
                   Telefono="691997550"
                }

                };

                foreach (Cliente item in lista)
                {
                    App.DataBase.SaveCliente(item);
                }
            }
        }



        private void CrearTablaBBDD()
        {
            _database.CreateTable<Categoria>();
            _database.CreateTable<Tienda>();
            _database.CreateTable<Cliente>();
        }

        public List<Categoria> GetAllCategoria()
        {
            return _database.Table<Categoria>().ToList();
        }

        public int SaveCategoria(Categoria item)
        {
            int result = 0;
            try
            {
                if (item.Id != 0)
                {
                    result = _database.Update(item);
                }
                else
                {
                    result = _database.Insert(item);
                }
            }
            catch (Exception e)
            {

                App.Current.MainPage.DisplayAlert("ERROR EN SaveCategoria", e.Message.ToString(), "OK");

            }

            return result;
        }

        public List<Tienda> GetAllTienda()
        {
            return _database.Table<Tienda>().ToList();
        }

        public int SaveTienda(Tienda item)
        {
            int result = 0;
            try
            {
                if (item.Id != 0)
                {
                    result = _database.Update(item);
                }
                else
                {
                    result = _database.Insert(item);
                }
            }
            catch (Exception e)
            {

                App.Current.MainPage.DisplayAlert("ERROR EN SaveTienda", e.Message.ToString(), "OK");

            }

            return result;
        }

        public List<Cliente> GetAllCliente()
        {
            return _database.Table<Cliente>().ToList();
        }

        public int SaveCliente(Cliente item)
        {
            int result = 0;
            try
            {
                if (item.Id != 0)
                {
                    result = _database.Update(item);
                }
                else
                {
                    result = _database.Insert(item);
                }
            }
            catch (Exception e)
            {

                App.Current.MainPage.DisplayAlert("ERROR EN SaveCliente", e.Message.ToString(), "OK");

            }

            return result;
        }

    }
}
