using Microsoft.Data.SqlClient;
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
            string query = @"SELECT u.IdUsuario, u.NombreUsuario, r.Nombre AS Rol 
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
        }
    }
}
