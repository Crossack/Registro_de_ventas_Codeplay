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
        private readonly string cadenaConexion =
            """Server=DESKTOP-KPD1OU0\SQLEXPRESS;""" +
            "Database=BDRegistroEstudiantes;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        public SqlConnection CrearConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
