using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Registro_de_ventas_Codeplay.Sql
{
    public class Conexion
    {
        private const string archivoConexion = "conexion.txt";

        public string ObtenerConexion()
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, archivoConexion);

            if (!File.Exists(ruta))
            {
                string plantilla = """Server=localhost\SQLEXPRESS;""" +
                    "Database=BDRegistroVentas;" + 
                    "Trusted_Connection=True;" +
                    "TrustServerCertificate=True;";
                File.WriteAllText(ruta, plantilla);

                MessageBox.Show(
                    $"No se encontró el archivo '{archivoConexion}'.\n" +
                    "Se ha creado uno de ejemplo en la carpeta de ejecución.\n" +
                    "Por favor revisa la cadena de conexión.",
                    "Configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return plantilla;
            }

            return File.ReadAllText(ruta).Trim();
        }

        public SqlConnection CrearConexion()
        {
            return new SqlConnection(ObtenerConexion());
        }
    }
}
