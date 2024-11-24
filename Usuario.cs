using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorJP1.shared
{
    public class Usuario
    {
        public int ID { get; set; }
        public string? NombreUsuario { get; set; } 
        public string? Contraseña { get; set; }
        public int Area { get; set; }
        public string TipoUsuario { get; set; } = string.Empty;
        public string? Cargo {  get; set; }
    }
}
