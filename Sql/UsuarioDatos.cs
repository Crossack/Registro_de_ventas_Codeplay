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
            const string sql = @"
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

        public List<Usuario> CargarUsuarios()
        {
            List<Usuario> lista = new();
            const string sql = @" 
                SELECT u.IdUsuario, u.NombreUsuario, u.FechaNac, u.CorreoElectronico, u.FechaRegistro, u.Idpais, 
                d.NombrePais, u.EstadoCuenta 
                FROM Usuario u 
                INNER JOIN Dispopais d ON u.Idpais = d.Idpais 
                ORDER BY u.NombreUsuario;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new (sql, conexion))
            {
                conexion.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new Usuario
                        {
                            IdUsuario = lector.GetInt32(0),
                            NombreUsuario = lector.GetString(1),
                            FechaNacimiento = lector.GetDateTime(2),
                            CorreoElectronico = lector.GetString(3),
                            FechaRegistro = lector.GetDateTime(4),
                            IdPais = lector.GetInt32(5),
                            Pais = lector.GetString(6),
                            EstadoCuenta = lector.GetBoolean(7),
                        });
                    }
                    return lista;
                }
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            const string sql = @"
                UPDATE Usuario
                SET NombreUsuario=@NombreUsuario, FechaNac=@FechaNac, Hashcontrasena=@Hashcontraseña, 
                CorreoElectronico=@CorreoElectronico, FechaRegistro=@FechaRegistro, Idpais=@Idpais
                WHERE Idusuario=@Idusuario;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new ( sql, conexion))
            {
                cmd.Parameters.AddWithValue("@Idusuario", usuario.IdUsuario);
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

        public void DesactivarUsuario(int idUsuario)
        {
            const string sql = @"
                UPDATE Usuario
                SET EstadoCuenta = 0
                WHERE Idusuario=@Idusuario;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new(sql, conexion))
            {
                cmd.Parameters.AddWithValue("@Idusuario", idUsuario);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool ExisteNombreUsuario(string nombreUsuario, int? idUsuario)
        {
            const string sql = @"
                SELECT Idusuario, NombreUsuario
                FROM Usuario
                WHERE NombreUsuario=@NombreUsuario;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new(sql, conexion))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                conexion.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        if (idUsuario == lector.GetInt32(0))
                        {
                            return false;
                        }
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
