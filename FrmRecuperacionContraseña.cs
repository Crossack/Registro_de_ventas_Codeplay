using Registro_de_ventas_Codeplay.Business;
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
    public partial class FrmRecuperacionContraseña : Form
    {
        private readonly LoginNegocios _loginNegocios = new();
        private CancellationTokenSource? cts;
        private string? usuarioRecuperacion;
        public FrmRecuperacionContraseña()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtRespuestaPregunta.Text = String.Empty;
            txtRespuestaPregunta.Enabled = false;
            lblRespuestaPregunta.Visible = false;
        }

        private void FrmRecuperacionContraseña_Load(object sender, EventArgs e)
        {

        }

        private async void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            btnBuscarUsuario.Enabled = false;
            cts = new CancellationTokenSource();

            try
            {
                var resultado = await _loginNegocios.RevisarUsuarioAsync(txtNombreUsuario.Text.Trim(), cts.Token);
                if (!resultado.Exito)
                {
                    MessageBox.Show(resultado.Mensaje,
                        "Validacion de usuario",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    lblRespuestaPregunta.Text = string.Empty;
                    txtNombreUsuario.Focus();
                    return;
                }

                lblRespuestaPregunta.Text = resultado.Pregunta;
                lblRespuestaPregunta.Visible = true;
                txtRespuestaPregunta.Enabled = true;
                btnValidarUsuario.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado " + ex.Message,
                    "Validacion de usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = null;
                txtRespuestaPregunta.Text = string.Empty;
                btnBuscarUsuario.Enabled = true;
            }
        }

        private async void BtnValidarUsuario_Click(object sender, EventArgs e)
        {
            grpValidacion.Enabled = false;
            cts = new CancellationTokenSource();
            bool exito = false;

            try
            {
                var resultado = await _loginNegocios.ValidarRespuestaAsync(
                    txtNombreUsuario.Text.Trim(),
                    txtRespuestaPregunta.Text.Trim().ToLower(),
                    cts.Token);

                if (!resultado.Exito)
                {
                    MessageBox.Show(resultado.Mensaje,
                        "Validacion de respuesta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                exito = true;
                usuarioRecuperacion = txtNombreUsuario.Text.Trim();
                MessageBox.Show(resultado.Mensaje,
                    "Validacion de respuesta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                grpValidacion.Visible = false;
                grpValidacion.Dock = DockStyle.None;
                grpCambioContraseña.Dock = DockStyle.Top;
                grpCambioContraseña.Visible = true;
                grpCambioContraseña.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado! " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = null;
                grpValidacion.Enabled = !exito;
            }
        }

        private void TxtNombreUsuario_Enter(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            grpCambioContraseña.Enabled = false;

            try
            {
                var resultado = await _loginNegocios.CambiarContraseñaAsync(
                    usuarioRecuperacion,
                    txtContraseña.Text,
                    cts.Token);

                if (!resultado.Exito)
                {
                    MessageBox.Show(resultado.Mensaje,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show(resultado.Mensaje,
                    "Completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado! " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                grpCambioContraseña.Enabled = true;
            }
        }
    }
}
