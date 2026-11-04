using Registro_de_ventas_Codeplay.Business;
using Registro_de_ventas_Codeplay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_ventas_Codeplay
{
    public partial class FrmPanelCodeplay : Form
    {
        private readonly UsuarioNegocio _usuarioNegocio = new();
        private readonly ServicioReporte _servicioReporte = new();

        public FrmPanelCodeplay()
        {
            InitializeComponent();
        }

        private async void FrmPanelCodeplay_Load(object sender, EventArgs e)
        {
            pnlSubMenuReportes.Visible = false;
            pnlMenuListaUsuario.Dock = DockStyle.Fill;
            pnlMenuEstadisticas.Dock = DockStyle.Fill;
            pnlMenuGenerarReporte.Dock = DockStyle.Fill;

            // Hola Mundo!
            lblBienvenida.Text =
                $"Bienvenido {SesionActiva.NombreUsuario} | {SesionActiva.RolUsuario}";
            await CargarJugadores();
        }

        private void BtnOpcionListaUsuario_Click(object sender, EventArgs e)
        {
            pnlMenuListaUsuario.Visible = true;
            pnlMenuEstadisticas.Visible = false;
            pnlMenuGenerarReporte.Visible = false;
        }

        private void BtnMenuRegistroUsuarios_Click(object sender, EventArgs e)
        {
            Hide();
            using (frmRegistros registros = new frmRegistros())
            {
                registros.ShowDialog();
            }
            Show();
        }

        private void BtnOpcionEstadistica_Click(object sender, EventArgs e)
        {
            pnlMenuEstadisticas.Visible = true;
            pnlMenuListaUsuario.Visible = false;
            pnlMenuGenerarReporte.Visible = false;
        }

        private void BtnOpcionReportes_Click(object sender, EventArgs e)
        {
            pnlSubMenuReportes.Visible = !pnlSubMenuReportes.Visible;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            SesionActiva.Cerrar();
            Close();
        }

        private async Task CargarJugadores()
        {
            List<Usuario> listaJugadores = await _usuarioNegocio.SolicitarListaUsuariosAsync();

            dgvListaUsuarios.DataSource = listaJugadores;

            // Ajustes visuales para la grilla
            dgvListaUsuarios.Columns["Contraseña"].Visible = false;
            dgvListaUsuarios.Columns["RowVersion"].Visible = false;
            dgvListaUsuarios.Columns["IdPais"].Visible = false;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaUsuarios.ReadOnly = true;
        }

        private void MbtnGenerarReporte_Click(object sender, EventArgs e)
        {
            pnlMenuGenerarReporte.Visible = true;
            pnlMenuListaUsuario.Visible = false;
            pnlMenuEstadisticas.Visible = false;
        }

        private async void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpFechaReporteInicio.Value;
            DateTime fechaHasta = dtpFechaReporteFinal.Value;
            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha inicial supera a la fecha de final, por favor verifique el periodo seleccionado",
                    "Incoherencia del periodo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            CancellationTokenSource cts = new CancellationTokenSource();
            btnGenerarReporte.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                List<Usuario> registro = await _usuarioNegocio.GenerarReportePorFechaAsync(fechaDesde, fechaHasta, cts.Token);

                if (registro.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros para el rango de fechas seleccionado.",
                        "No se encontraron registros",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                byte[] archivoReporte = _servicioReporte.GenerarReporteUsuarios(registro,
                    $"del {fechaDesde.Date:dd/MM/yyyy} hasta {fechaHasta.Date:dd/MM/yyyy}");



                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Libro de Excel (*.xlsx)|*.xlsx";
                    sfd.FileName = $"Reporte_Registros_{fechaDesde:yyyyMMdd}_{fechaHasta:yyyyMMdd}.xlsx";
                    sfd.Title = "Guardar Reporte de Excel";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        await File.WriteAllBytesAsync(sfd.FileName, archivoReporte);

                        DialogResult respuesta = MessageBox.Show("El archivo se generó correctamente. ¿Deseas abrirlo ahora?",
                                                        "Reporte Generado", 
                                                        MessageBoxButtons.YesNo, 
                                                        MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            // Abre el archivo automáticamente con la aplicación predeterminada del sistema
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName)
                            {
                                UseShellExecute = true
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}",
                        "Error del Sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
            }
            finally
            {
                btnGenerarReporte.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
    }
}
