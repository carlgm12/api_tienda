using System;
using System.Collections.Generic;

namespace apiTienda.Models
{
    public partial class Usuario
    {
        public long IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Clave { get; set; }
    }
}
