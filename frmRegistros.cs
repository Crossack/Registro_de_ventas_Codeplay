using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_de_ventas_Codeplay.Business;
using Registro_de_ventas_Codeplay.Models;

namespace Registro_de_ventas_Codeplay
{
    public partial class frmRegistros : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private DatosNegocios datosNegocios = new DatosNegocios();

        private Usuario? usuarioSeleccionado;

        private CancellationTokenSource? cts;

        //Datos para los colores de la ventana principal

        private readonly Color ColorFondo = ColorTranslator.FromHtml("#f1f2fc");
        private readonly Color ColorPrimario = ColorTranslator.FromHtml("#374ad1");
        private readonly Color ColorSecundario = ColorTranslator.FromHtml("#e79d94");
        private readonly Color ColorTexto = ColorTranslator.FromHtml("#07091f");
        private readonly Color ColorBlanco = Color.White;

        public frmRegistros()
        {
            InitializeComponent();

            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                
            }
        }

        private async Task CargarPaisesAsync()
        {
            try
            {
                cmbPais.DisplayMember = "NombrePais"; // Asigna los nombres de los paises
                cmbPais.ValueMember = "Idpais"; // Asigna los id segun la tabla Idpais
                cmbPais.DataSource = await datosNegocios.SolicitarListaPaises();
                cmbPais.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Hubo un error inesperado: " + ex,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
            cts = new CancellationTokenSource();

            try
            {
                if (!ValidarDatos())
                {
                    return;
                }

                Usuario usuario = new Usuario
                {
                    IdUsuario = usuarioSeleccionado == null ? 0 : usuarioSeleccionado.IdUsuario,
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Contraseña = txtContrasenia.Text.Trim(),
                    FechaNacimiento = dtpFechaNac.Value.Date,
                    FechaRegistro = usuarioSeleccionado?.FechaRegistro,
                    CorreoElectronico = txtCorreo.Text.Trim(),
                    IdPais = Convert.ToInt32(cmbPais.SelectedValue),
                    RowVersion = usuarioSeleccionado?.RowVersion
                };

                if (usuarioSeleccionado is null)
                {
                    await usuarioNegocio.RegistrarUsuarioAsync(usuario, cts.Token);
                }
                else
                {
                    if (await usuarioNegocio.ModificarUsuarioAsync(usuario, cts.Token))
                    {
                        MessageBox.Show(
                            "Otro operador ya modifico este registro, intentelo de nuevo",
                            "Incoherencia de registro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        await CargarDatosAsync();
                        return;
                    }
                }

                MessageBox.Show("El usuario se guardo exitosamente",
                    "Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error: " + ex.Message,
                    "Error general",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = null;
                btnRegistrar.Enabled = true;
            }
            // Si ValidarDatos() falla, evita cargar los datos innecesariamente
            await CargarDatosAsync();
        }


        private bool ValidarDatos()
        {
            try
            {
                if (SesionActiva.RolUsuario == "Lector")
                {
                    MessageBox.Show(
                        "No tienes permisos para registrar cuentas!",
                        "Permiso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("El nombre es obligatorio!!");
                    return false;
                }

                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("El correo es obligatorio");
                    return false;
                }

                if (cmbPais.SelectedValue == null)
                {
                    MessageBox.Show("Elige un pais!");
                    return false;
                }

                if (string.IsNullOrEmpty(txtContrasenia.Text))
                {
                    MessageBox.Show("La contraseña es obligatoria");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no se procesaron correctamente: " + ex);
                return false;
            }
            return true;
        }

        private void LimpiarFormulario()
        {
            usuarioSeleccionado = null;
            txtCorreo.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
            cmbPais.SelectedIndex = -1;
            txtUsuario.Focus();
            btnRegistrar.Text = "&Registrar";
        }

        // Carga y refresca la lista de la tabla usuarios
        private async Task CargarDatosAsync()
        {
            try
            {
                dgvRegistros.DataSource = await usuarioNegocio.SolicitarListaUsuariosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A occurrido un error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Inicializacion del formulario y carga los nuevos cambios
        private async void frmRegistros_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync();
            await CargarPaisesAsync();

            dgvRegistros.Columns["Contraseña"].Visible = false;
            dgvRegistros.Columns["IdPais"].Visible = false;
            dgvRegistros.Columns["RowVersion"].Visible = false;

            lblBienvenida.Text = $"{SesionActiva.NombreUsuario} ({SesionActiva.RolUsuario})";
            if (SesionActiva.RolUsuario == "Lector")
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }

            AplicarCoolores();
            ConfigurarTarjetaRegistro();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Desea cerrar el programa?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                cts?.Cancel();
                cts?.Dispose();
                cts = null;
                SesionActiva.Cerrar();
                Close();
            }

        }

        private void AplicarCoolores() //Aplica los colores automaticamente 
        {
            this.BackColor = ColorFondo;
            grpRegistroEst.BackColor = ColorBlanco;
            grpRegistroEst.ForeColor = ColorTexto;

            txtUsuario.BackColor = ColorBlanco;
            txtUsuario.ForeColor = ColorTexto;
            txtContrasenia.BackColor = ColorBlanco;
            txtContrasenia.ForeColor = ColorTexto;
            txtCorreo.BackColor = ColorBlanco;
            txtCorreo.ForeColor = ColorTexto;
            cmbPais.BackColor = ColorBlanco;
            cmbPais.ForeColor = ColorTexto;

            btnRegistrar.BackColor = ColorPrimario;
            btnRegistrar.ForeColor = ColorBlanco;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.FlatAppearance.BorderSize = 0;

            btnSalir.BackColor = ColorSecundario;
            btnSalir.ForeColor = ColorTexto;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;

            dgvRegistros.BackgroundColor = ColorBlanco;
            dgvRegistros.BorderStyle = BorderStyle.None;
            dgvRegistros.DefaultCellStyle.BackColor = ColorBlanco;
            dgvRegistros.DefaultCellStyle.ForeColor = ColorTexto;
            dgvRegistros.DefaultCellStyle.SelectionBackColor = ColorPrimario;
            dgvRegistros.DefaultCellStyle.SelectionForeColor = ColorBlanco;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = ColorPrimario;
            dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor = ColorBlanco;

            /////////////
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.ScrollBars = ScrollBars.Vertical;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2563EB");
            dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            dgvRegistros.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            dgvRegistros.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#3B82F6");
            dgvRegistros.DefaultCellStyle.SelectionForeColor = Color.White;


            /////////////////////// Fuentes

            Font fontTitulo = new Font("Segoe UI", 15f, FontStyle.Bold);
            Font fontLabels = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold);
            Font fontInputs = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            Font fontManager = new Font("Segoe UI", 9f, FontStyle.Regular);

            Color colorTextoPrincipal = ColorTranslator.FromHtml("#1E293B"); // Slate oscuro
            Color colorTextoSecundario = ColorTranslator.FromHtml("#64748B"); // Gris suave

            lblTitulo.Font = fontTitulo;
            lblTitulo.ForeColor = colorTextoPrincipal;

            lblUsuario.Font = fontLabels;
            lblUsuario.ForeColor = colorTextoSecundario;

            lblcontrasena.Font = fontLabels;
            lblcontrasena.ForeColor = colorTextoSecundario;

            fechanac.Font = fontLabels;
            fechanac.ForeColor = colorTextoSecundario;

            lblemail.Font = fontLabels;
            lblemail.ForeColor = colorTextoSecundario;

            lblpais.Font = fontLabels;
            lblpais.ForeColor = colorTextoSecundario;

            lblBienvenida.Font = fontManager;
            lblBienvenida.ForeColor = colorTextoSecundario;

            dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvRegistros.DefaultCellStyle.Font = fontInputs;
        }

        private void ConfigurarTarjetaRegistro() // Colores de la tarjeta de registro
        {


            this.BackColor = ColorTranslator.FromHtml("#F1F5F9");
            grpRegistroEst.BackColor = Color.White;


            Font fontLabel = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
            Color colorTextoLabels = ColorTranslator.FromHtml("#475569"); // Gris pizarra elegante
            Color bordeInputs = ColorTranslator.FromHtml("#CBD5E1");

            //  Configurar etiquetas PoisonLabel (Obligatorio UseCustom)
            PoisonLabel[] labels = { lblUsuario, lblcontrasena, fechanac, lblemail, lblpais };
            foreach (var lbl in labels)
            {
                if (lbl != null)
                {
                    lbl.UseCustomForeColor = true;
                    lbl.UseCustomFont = true;
                    lbl.Font = fontLabel;
                    lbl.ForeColor = colorTextoLabels;
                }
            }

            // Campos de texto
            txtUsuario.BorderColor = bordeInputs;
            txtUsuario.CustomBGColor = Color.White;

            txtContrasenia.BorderColor = bordeInputs;
            txtContrasenia.CustomBGColor = Color.White;
            txtContrasenia.UseSystemPasswordChar = true;

            txtCorreo.BorderColor = bordeInputs;
            txtCorreo.CustomBGColor = Color.White;

            // Selector de fecha
            dtpFechaNac.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            dtpFechaNac.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;

            // Texto de usuario inferior
            lblBienvenida.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            lblBienvenida.ForeColor = ColorTranslator.FromHtml("#64748B");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.CurrentRow?.DataBoundItem is not Usuario usuario)
            {
                MessageBox.Show(
                    "Por favor primero seleccione un usuario!",
                    "Comprobacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            usuarioSeleccionado = usuario;
            txtUsuario.Text = usuarioSeleccionado.NombreUsuario;
            dtpFechaNac.Value = usuarioSeleccionado.FechaNacimiento;
            txtCorreo.Text = usuarioSeleccionado.CorreoElectronico;
            cmbPais.SelectedValue = usuarioSeleccionado.IdPais;

            btnRegistrar.Text = "&Actualizar";
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.CurrentRow?.DataBoundItem is not Usuario usuario)
            {
                MessageBox.Show(
                    "Por favor primero seleccione un usuario!",
                    "Comprobacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            btnEliminar.Enabled = false;
            cts = new CancellationTokenSource();

            DialogResult confirmarEliminarUsuario = MessageBox.Show(
                $"Estas seguro que quieres eliminar el usuario {usuario.NombreUsuario}?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmarEliminarUsuario == DialogResult.Yes)
            {
                try
                {
                    await usuarioNegocio.EliminarUsuarioAsync(usuario.IdUsuario, cts.Token);
                    MessageBox.Show(
                        $"Usuario {usuario.NombreUsuario} eliminado!",
                        "Usuario eliminado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show(
                        "Se cancelo la operacion!",
                        "Detener operacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                finally
                {
                    cts.Cancel();
                    cts.Dispose();
                    cts = null;
                }
                LimpiarFormulario();
                await CargarDatosAsync();
            }

            btnEliminar.Enabled = true;
        }
    }
}
