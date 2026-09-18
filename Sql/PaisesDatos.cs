using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Sql
{
    public class PaisesDatos
    {
        public DataTable CargarPaises()
        {
            string query = @"SELECT Idpais, NombrePais FROM Dispopais ORDER BY NombrePais ASC";

            // Crea la conexion, la consulta y obtiene los datos de los paises
            using (SqlConnection conexion = Conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
            {
                conexion.Open();
                DataTable dataTable = new DataTable();
                adaptador.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
