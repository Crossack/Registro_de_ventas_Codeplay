using Registro_de_ventas_Codeplay.Models;
using Registro_de_ventas_Codeplay.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Business
{
    public class UsuarioNegocio
    {
        private readonly UsuarioDatos usuarioDatos = new UsuarioDatos();

        public async Task RegistrarUsuarioAsync(Usuario usuario, CancellationToken token)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
            {
                throw new ArgumentException("Ingrese un nombre de usuario!");
            }
            if (string.IsNullOrWhiteSpace(usuario.Contraseña) || usuario.Contraseña.Length <= 7)
            {
                throw new ArgumentException("Ingrese una contraseña con almenos 8 caracteres!");
            }
            if (string.IsNullOrWhiteSpace(usuario.CorreoElectronico))
            {
                throw new ArgumentException("Ingrese un correo electronico!");
            }
            if (usuario.IdPais <= 0)
            {
                throw new ArgumentException("Seleccione un pais!");
            }
            if (await usuarioDatos.ExisteNombreUsuarioAsync(usuario.NombreUsuario, null))
            {
                throw new ArgumentException("Ese nombre de usuario ya esta ocupado!");
            }

            usuario.Contraseña = Hasher.GenerarHashSHA256(usuario.Contraseña);
            await usuarioDatos.AgregarUsuarioAsync(usuario, token);
        }

        public async Task<List<Usuario>> SolicitarListaUsuariosAsync()
        {
            return await usuarioDatos.CargarUsuariosAsync();
        }

        public async Task<bool> ModificarUsuarioAsync(Usuario usuario, CancellationToken token)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
            {
                throw new ArgumentException("Ingrese un nombre de usuario!");
            }
            if (string.IsNullOrWhiteSpace(usuario.Contraseña) || usuario.Contraseña.Length <= 7)
            {
                throw new ArgumentException("Ingrese una contraseña con almenos 8 caracteres!");
            }
            if (string.IsNullOrWhiteSpace(usuario.CorreoElectronico))
            {
                throw new ArgumentException("Ingrese un correo electronico!");
            }
            if (usuario.IdPais <= 0)
            {
                throw new ArgumentException("Seleccione un pais!");
            }
            if (await usuarioDatos.ExisteNombreUsuarioAsync(usuario.NombreUsuario, usuario.IdUsuario))
            {
                throw new ArgumentException("Ese nombre de usuario ya esta ocupado!");
            }

            usuario.Contraseña = Hasher.GenerarHashSHA256(usuario.Contraseña);
            return await usuarioDatos.ActualizarUsuarioAsync(usuario, token);
        }

        public async Task EliminarUsuarioAsync(int idUsuario, CancellationToken token)
        {
            await usuarioDatos.DesactivarUsuarioAsync(idUsuario, token);
        }
    }
}
