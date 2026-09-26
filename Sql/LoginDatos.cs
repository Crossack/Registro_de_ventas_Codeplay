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
        public Usuario? IniciarSesion(string usuario, string contraseña)
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
                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            IdUsuario = reader.GetInt32(0),
                            NombreUsuario = reader.GetString(1),
                            Rol = reader.GetString(2)
                        };
                    }
                }
            }
        return null;
        }
    }
}
