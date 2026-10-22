using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Models
{
    public class LoginUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
        public string? Pregunta {  get; set; } = string.Empty;
        public string? Respuesta {  get; set; } = string.Empty;
    }
}
