using Registro_de_ventas_Codeplay.Models;
using Registro_de_ventas_Codeplay.Sql;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Business
{
    public class LoginNegocios
    {
        private readonly LoginDatos loginDatos = new LoginDatos();
        public bool ValidarSesion(string usuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                throw new ArgumentException("Ingrese tanto el usuario como la contraseña.");
            }

            string hash = Hasher.GenerarHashSHA256(contraseña);

            // Validar existencia en la capa de datos
            Usuario? usuarioValido = loginDatos.IniciarSesion(usuario, hash);

            if (usuarioValido == null)
            {
                return false; // Credenciales invalidas
            }

            // Inicializar los datos en memoria de la sesión
            SesionActiva.Iniciar(usuarioValido);
            return true;
        }

        public void CerrarSesion()
        {
            SesionActiva.Cerrar();
        }
    }
}
