using System;
using System.Collections.Generic;

namespace ProyectoDefinitivo.Models
{
    public partial class TipoMovimiento
    {
        public TipoMovimiento()
        {
            MovimientoCuenta = new HashSet<MovimientoCuenta>();
        }

        public int IdTipoMovimiento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<MovimientoCuenta> MovimientoCuenta { get; set; }
    }
}
