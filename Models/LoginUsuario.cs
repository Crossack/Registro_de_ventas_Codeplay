using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Models
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string? NombreRol { get; set; }
    }

    public class LoginUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public int IdRol { get; set; }
        public string? PreguntaRec { get; set; }
        public string? RespuestaRec { get; set; }

        // Para INNER JOIN en EF Core
        public Rol? Rol { get; set; }
    }
}
