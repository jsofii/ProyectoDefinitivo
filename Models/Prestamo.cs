using System;
using System.Collections.Generic;

namespace ProyectoDefinitivo.Models
{
    public partial class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoPrestamo { get; set; }
        public decimal Saldo { get; set; }
        public string Moneda { get; set; }
        public decimal ValorDia { get; set; }

        public TipoPrestamo IdTipoPrestamoNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
    }
}
