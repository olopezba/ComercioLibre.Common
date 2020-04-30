using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComercioLibre.Data.Entities
{
    public class Horario
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public int TiendaId { get; set; }

        public int diaSemanaId { get; set; }

        public DateTime HoraApertura { get; set; }

        public DateTime HoraCierre { get; set; }
    }
}
