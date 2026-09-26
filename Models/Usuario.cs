using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario {  get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; } = string.Empty;
        public int IdPais { get; set; }
        public string Rol { get; set; } = string.Empty;
    }
}
