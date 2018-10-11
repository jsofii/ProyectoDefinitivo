using System;
using System.Collections.Generic;

namespace ProyectoDefinitivo.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cuenta = new HashSet<Cuenta>();
            Prestamo = new HashSet<Prestamo>();
        }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Password { get; set; }

        public ICollection<Cuenta> Cuenta { get; set; }
        public ICollection<Prestamo> Prestamo { get; set; }
    }
}
