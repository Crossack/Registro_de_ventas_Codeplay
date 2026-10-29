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
                throw new ArgumentException("Ingrese tanto el usuario como la contraseña.");

            string hash = Hasher.GenerarHashSHA256(contraseña);

            // Validar existencia en la capa de datos
            LoginUsuario? usuarioValido = await loginDatos.IniciarSesionAsync(usuario, hash, token);

            if (usuarioValido == null)
                return false; // Credenciales invalidas

            // Inicializar los datos en memoria de la sesión
            SesionActiva.Iniciar(usuarioValido);
            return true;
        }

        public async Task<(bool Exito, string Mensaje, string? Pregunta)> RevisarUsuarioAsync(string usuario, CancellationToken token)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                return (false, "Ingrese el nombre de usuario!", null);

            string? pregunta = await loginDatos.ExisteUsuarioAsync(usuario, token);

            if (pregunta == null)
                return (false, "El usuario no existe!", null);

            return (true, "Todo en orden :)", pregunta);
        }

        public async Task<(bool Exito, string Mensaje)> ValidarRespuestaAsync(string usuario, string respuesta, CancellationToken token)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                return (false, "Ingrese el nombre de usuario!");

            string hashRespuesta = Hasher.GenerarHashSHA256(respuesta);
            bool exito = await loginDatos.RevisarRepuestaRecuperacionAsync(usuario, hashRespuesta, token);

            if (!exito)
            {
                return (false, "Respuesta Incorrecta!");
            }

            return (exito, "Todo en orden :)");
        }

        public async Task<(bool Exito, string Mensaje)> CambiarContraseñaAsync(string? usuario, string contraseña, CancellationToken token)
        {
            if (string.IsNullOrWhiteSpace(contraseña) || contraseña.Length < 8)
                return (false, "Ingrese una contraseña de almenos 8 caracteres!");

            string hash = Hasher.GenerarHashSHA256(contraseña);
            bool exito = await loginDatos.ActualizarContraseñaAsync(usuario, hash, token);

            if (!exito)
            {
                return (false, "No se encontro el usuario!, intentelo de nuevo");
            }

            return (exito, "Todo bien :)");
        }

        public void CerrarSesion()
        {
            SesionActiva.Cerrar();
        }
    }
}
