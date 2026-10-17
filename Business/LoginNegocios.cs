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
        public async Task<bool> ValidarSesionAsync(string usuario, string contraseña, CancellationToken token)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                throw new ArgumentException("Ingrese tanto el usuario como la contraseña.");
            }

            string hash = Hasher.GenerarHashSHA256(contraseña);

            // Validar existencia en la capa de datos
            LoginUsuario? usuarioValido = await loginDatos.IniciarSesionAsync(usuario, hash, token);

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
