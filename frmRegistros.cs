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

        public frmRegistros()
        {
            InitializeComponent();
        }

        private void CargarPaises()
        {
            try
            {
                cmbPais.DisplayMember = "NombrePais"; // Asigna los nombres de los paises
                cmbPais.ValueMember = "Idpais"; // Asigna los id segun la tabla Idpais
                cmbPais.DataSource = datosNegocios.SolicitarListaPaises();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            try
            {
                Usuario usuario = new Usuario
                {
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Contraseña = txtContrasenia.Text.Trim(),
                    FechaNacimiento = dtpFechaNac.Value.Date,
                    CorreoElectronico = txtCorreo.Text.Trim(),
                    IdPais = Convert.ToInt32(cmbPais.SelectedValue)
                };

                usuarioNegocio.RegistrarUsuario(usuario);

                MessageBox.Show("Registro exitososo",
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
                MessageBox.Show("A ocurrido un error: " + ex .Message,
                    "Error general",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            CargarDatos();
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
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContrasenia.Clear();
            cmbPais.SelectedIndex = -1;
            txtUsuario.Focus();
        }

        // Carga y refresca la lista de la tabla usuarios
        private void CargarDatos()
        {
            try
            {
                dgvRegistros.DataSource = usuarioNegocio.SolicitarListaUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A occurrido un error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Inicializacion del formulario
        private void frmRegistros_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPaises();

            lblBienvenida.Text = $"Bienvenido {SesionActiva.NombreUsuario} ({SesionActiva.RolUsuario}).";
            if (SesionActiva.RolUsuario == "Lector")
            {
                grpRegistroEst.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Desea cerrar el programa?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
