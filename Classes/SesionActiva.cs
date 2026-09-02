using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Classes
{
    public static class SesionActiva
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; } = string.Empty;
        public static string RolUsuario { get; set; } = string.Empty;
    }
}
