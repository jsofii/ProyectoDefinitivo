using System;
using System.Collections.Generic;

namespace ProyectoDefinitivo.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            MovimientoCuenta = new HashSet<MovimientoCuenta>();
        }

        public int IdCuenta { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public decimal Disponible { get; set; }

        public TipoCuenta IdTipoCuentaNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
        public ICollection<MovimientoCuenta> MovimientoCuenta { get; set; }
    }
}
