using Microsoft.Data.SqlClient;
using Registro_de_ventas_Codeplay.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Sql
{
    public class UsuarioDatos
    {
        public void AgregarUsuario(Usuario usuario)
        {
            string sql = @"
             INSERT INTO Usuario
             VALUES
             (@NombreUsuario, @FechaNac, @CorreoElectronico, @Hashcontrasena, @FechaRegistro, @idpais, 1)";

            try
            {
                using (SqlConnection conexion = Conexion.CrearConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@FechaNac", usuario.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Hashcontrasena", usuario.Contraseña);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                        cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Today);
                        cmd.Parameters.AddWithValue("@Idpais", usuario.IdPais);

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("Ocurrio un error al agregar el usuario: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("A occurrido un error!: " + ex.Message);
            }
        }

        public DataTable CargarUsuarios()
        {
            string sql = @" 
                SELECT u.IdUsuario, u.NombreUsuario, u.FechaNac, u.CorreoElectronico, u.FechaRegistro, d.NombrePais, u.EstadoCuenta 
                FROM Usuario u 
                INNER JOIN Dispopais d ON u.Idpais = d.Idpais 
                ORDER BY u.NombreUsuario;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }
    }
}
