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
        public async Task AgregarUsuarioAsync(Usuario usuario, CancellationToken token)
        {
            const string sql = @"
             INSERT INTO Usuario (NombreUsuario, FechaNac, CorreoElectronico, Hashcontrasena,
             FechaRegistro, Idpais, EstadoCuenta)
             VALUES
             (@NombreUsuario, @FechaNac, @CorreoElectronico, @Hashcontrasena, @FechaRegistro, @Idpais, 1)";

            try
            {
                using (SqlConnection conexion = Conexion.CrearConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@FechaNac", usuario.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                        cmd.Parameters.AddWithValue("@Hashcontrasena", usuario.Contraseña);
                        cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Today);
                        cmd.Parameters.AddWithValue("@Idpais", usuario.IdPais);

                        await conexion.OpenAsync(token);
                        await cmd.ExecuteNonQueryAsync(token);
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

        public async Task<List<Usuario>> CargarUsuariosAsync()
        {
            List<Usuario> lista = new();
            const string sql = @" 
                SELECT u.IdUsuario, u.NombreUsuario, u.FechaNac, u.CorreoElectronico, u.FechaRegistro, u.Idpais, 
                d.NombrePais, u.EstadoCuenta, u.RowVer
                FROM Usuario u 
                INNER JOIN Dispopais d ON u.Idpais = d.Idpais 
                WHERE EstadoCuenta = 1 
                ORDER BY u.NombreUsuario;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new (sql, conexion))
            {
                await conexion.OpenAsync();
                using (SqlDataReader lector = await cmd.ExecuteReaderAsync())
                {
                    while (await lector.ReadAsync())
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
                            RowVersion = (byte[])lector[8]
                        });
                    }
                    return lista;
                }
            }
        }

        public async Task<bool> ActualizarUsuarioAsync(Usuario usuario, CancellationToken token)
        {
            const string sql = @"
                UPDATE Usuario
                SET NombreUsuario=@NombreUsuario, FechaNac=@FechaNac, Hashcontrasena=@Hashcontraseña, 
                CorreoElectronico=@CorreoElectronico, FechaRegistro=@FechaRegistro, Idpais=@Idpais
                WHERE Idusuario=@Idusuario AND RowVer=@RowVersion;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new (sql, conexion))
            {
                cmd.Parameters.AddWithValue("@Idusuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@FechaNac", usuario.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Hashcontraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Today);
                cmd.Parameters.AddWithValue("@Idpais", usuario.IdPais);
                cmd.Parameters.AddWithValue("@RowVersion", usuario.RowVersion);

                await conexion.OpenAsync(token);
                int result = await cmd.ExecuteNonQueryAsync(token);

                return result == 0;
            }
        }

        public async Task DesactivarUsuarioAsync(int idUsuario, CancellationToken token)
        {
            const string sql = @"
                UPDATE Usuario
                SET EstadoCuenta = 0
                WHERE Idusuario=@Idusuario;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new(sql, conexion))
            {
                cmd.Parameters.AddWithValue("@Idusuario", idUsuario);

                await conexion.OpenAsync(token);
                await cmd.ExecuteNonQueryAsync(token);
            }
        }

        public async Task<bool> ExisteNombreUsuarioAsync(string nombreUsuario, int? idUsuario)
        {
            const string sql = @"
                SELECT Idusuario, NombreUsuario
                FROM Usuario
                WHERE NombreUsuario=@NombreUsuario;";

            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new(sql, conexion))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                await conexion.OpenAsync();
                using (SqlDataReader lector = await cmd.ExecuteReaderAsync())
                {
                    if (await lector.ReadAsync())
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
