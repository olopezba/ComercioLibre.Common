using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComercioLibre.Data.Entities
{
    public class Tienda
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string PaginaWeb { get; set; }
        public int CategoriaId { get; set; }
        public string Comentario { get; set; }
    }
}
