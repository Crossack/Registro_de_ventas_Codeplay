using Registro_de_ventas_Codeplay.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Business
{
    public class DatosNegocios
    {
        private readonly PaisesDatos paisesDatos = new PaisesDatos();
        public DataTable SolicitarListaPaises()
        {
            return paisesDatos.CargarPaises();
        }
    }
}
