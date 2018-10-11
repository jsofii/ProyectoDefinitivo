using System;
using System.Collections.Generic;

namespace ProyectoDefinitivo.Models
{
    public partial class MovimientoCuenta
    {
        public int IdMovimientoCuenta { get; set; }
        public int IdCuenta { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal Valor { get; set; }
        public int IdTipoMovimiento { get; set; }
        public string Descripcion { get; set; }

        public Cuenta IdCuentaNavigation { get; set; }
        public TipoMovimiento IdTipoMovimientoNavigation { get; set; }
    }
}
