using ClosedXML.Excel;
using Registro_de_ventas_Codeplay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Business
{
    public class ServicioReporte
    {
        public byte[] GenerarReporteUsuarios(List<Usuario> listaUsuarios, string tituloFiltro)
        {
            using (var workbook = new XLWorkbook())
            {
                var hoja = workbook.Worksheets.Add("Usuarios Registrados");

                // Titulo del reporte
                hoja.Cell("A1").Value = "REPORTE DE USUARIOS REGISTRADOS";
                hoja.Cell("A1").Style.Font.Bold = true;
                hoja.Cell("A1").Style.Font.FontSize = 14;
                hoja.Cell("A2").Value = $"Criterio: {tituloFiltro}";
                hoja.Cell("A2").Style.Font.Italic = true;

                int filaInicio = 4; // Para mantenimiento
                hoja.Cell(filaInicio, 1).Value = "ID";
                hoja.Cell(filaInicio, 2).Value = "Nombre Completo";
                hoja.Cell(filaInicio, 3).Value = "Correo";
                hoja.Cell(filaInicio, 4).Value = "Rol";
                hoja.Cell(filaInicio, 5).Value = "País";
                hoja.Cell(filaInicio, 6).Value = "Fecha Registro";

                var rangoCabecera = hoja.Range(filaInicio, 1, filaInicio, 6);
                rangoCabecera.Style.Font.Bold = true;
                rangoCabecera.Style.Fill.BackgroundColor = XLColor.FromArgb(41, 128, 185); // Azul elegante
                rangoCabecera.Style.Font.FontColor = XLColor.White;

                int filaActual = filaInicio + 1;
                foreach (var user in listaUsuarios)
                {
                    hoja.Cell(filaActual, 1).Value = user.IdUsuario;
                    hoja.Cell(filaActual, 2).Value = user.NombreUsuario;
                    hoja.Cell(filaActual, 3).Value = user.CorreoElectronico;
                    //hoja.Cell(filaActual, 4).Value = user.NombreRol;
                    hoja.Cell(filaActual, 5).Value = user.Pais;
                    hoja.Cell(filaActual, 6).Value = user.FechaRegistro;
                    hoja.Cell(filaActual, 6).Style.DateFormat.Format = "yyyy-MM-dd HH:mm";
                    filaActual++;
                }

                var rangoDatos = hoja.Range(filaInicio, 1, filaActual - 1, 6);
                rangoDatos.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                rangoDatos.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                hoja.Columns().AdjustToContents();

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
    }
}
