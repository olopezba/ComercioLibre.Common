using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComercioLibre.Data.Entities
{
    public class CitaPrevia
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int TiendaId { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public bool Cancelado { get; set; }
    }
}
