using System;
using System.Collections.Generic;

namespace ProyectoDefinitivo.Models
{
    public partial class TipoCuenta
    {
        public TipoCuenta()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        public int IdTipoCuenta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Cuenta> Cuenta { get; set; }
    }
}
