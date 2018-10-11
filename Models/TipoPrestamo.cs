using System;
using System.Collections.Generic;

namespace ProyectoDefinitivo.Models
{
    public partial class TipoPrestamo
    {
        public TipoPrestamo()
        {
            Prestamo = new HashSet<Prestamo>();
        }

        public int IdTipoPrestamo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Prestamo> Prestamo { get; set; }
    }
}
