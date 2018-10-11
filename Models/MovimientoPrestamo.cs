using System;
using System.Collections.Generic;

namespace ProyectoDefinitivo.Models
{
    public partial class MovimientoPrestamo
    {
        public int IdMovimientoPrestamo { get; set; }
        public int IdPrestamo { get; set; }
        public DateTime Fecha { get; set; }
        public string NumDocumento { get; set; }
        public decimal Cuota { get; set; }
        public decimal Capital { get; set; }
        public decimal Total { get; set; }
    }
}
