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
        public void RegistrarUsuario(Usuario usuario)
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

            usuario.Contraseña = Hasher.GenerarHashSHA256(usuario.Contraseña);

            usuarioDatos.AgregarUsuario(usuario);
        }

        public DataTable SolicitarListaUsuarios()
        {
            return usuarioDatos.CargarUsuarios();
        }
    }
}
