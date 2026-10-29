using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Registro_de_ventas_Codeplay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Sql
{
    public class LoginDatos
    {
        public async Task<LoginUsuario?> IniciarSesionAsync(string usuario, string contraseña, CancellationToken token)
        {
            // ADO.NET (Antiguo)
            /*string query = @"SELECT u.IdUsuario, u.NombreUsuario, r.Nombre AS Rol 
                 FROM LoginUsuarios u 
                 INNER JOIN Roles r ON u.IdRol = r.IdRol 
                 WHERE u.NombreUsuario = @usuario AND u.PasswordHash = @password";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", contraseña);

                await conexion.OpenAsync(token);
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync(token))
                {
                    if (await reader.ReadAsync(token))
                    {
                        return new LoginUsuario
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Rol = reader.GetString(2)
                        };
                    }
                }
            }
        return null;
        } */

            // EF Core
            using (var db = new LoginConexionEFCore())
            {
                return await db.LoginUsuarios.AsNoTracking().Include(u => u.Rol).FirstOrDefaultAsync(
                    u => u.Nombre == usuario &&
                    u.Contraseña == contraseña, token);
            }
        }

        public async Task<string?> ExisteUsuarioAsync(string nombreUsuario, CancellationToken token)
        {
            using (var db = new LoginConexionEFCore())
            {
                return await db.LoginUsuarios
                    .AsNoTracking()
                    .Where(u => u.Nombre == nombreUsuario.Trim())
                    .Select(u => u.PreguntaRec)
                    .FirstOrDefaultAsync(token);
            }
        }

        public async Task<bool> RevisarRepuestaRecuperacionAsync(string nombreUsuario, string respuesta, CancellationToken token)
        {
            using (var db = new LoginConexionEFCore())
            {
                return await db.LoginUsuarios
                    .AsNoTracking()
                    .AnyAsync(u => u.Nombre == nombreUsuario && u.RespuestaRec == respuesta, token);
            }
        }

        public async Task<bool> ActualizarContraseñaAsync(string? nombreUsuario, string contraseña, CancellationToken token)
        {
            using (var db = new LoginConexionEFCore())
            {
                var usuario = await db.LoginUsuarios.FirstOrDefaultAsync(u => u.Nombre == nombreUsuario, token);

                if (usuario == null)
                    return false;

                usuario.Contraseña = contraseña;

                await db.SaveChangesAsync(token);
                return true;
            }
        }
    }
}
