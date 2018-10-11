using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoDefinitivo.Models;
namespace ProyectoDefinitivo.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        proyectoDefContext context = new proyectoDefContext();
        [HttpGet]
        [Route("DameDatos")]
        public List<Usuario> Obtenerdatos()
        {
            return context.Usuario.ToList();
        }
        
    }
}