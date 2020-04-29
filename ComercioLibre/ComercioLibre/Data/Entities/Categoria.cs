using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComercioLibre.Data.Entities
{
    public class Categoria
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
    }
}
