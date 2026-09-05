using Registro_de_ventas_Codeplay.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Registro_de_ventas_Codeplay.Classes;

namespace Registro_de_ventas_Codeplay
{
    public partial class frmRegistros : Form
    {
        // Instancia de la conexion para gestionar la BD
        private Conexion cadConexion = new Conexion();

        public frmRegistros()
        {
            InitializeComponent();
        }


        private void CargarPaises()
        {
            string query = @"SELECT Idpais, NombrePais FROM Dispopais ORDER BY NombrePais ASC";
            try
            {
                // Crea la conexion, la consulta y obtiene los datos de los paises
                using (SqlConnection conexion = cadConexion.CrearConexion())
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                {
                    conexion.Open();
                    DataTable dataTable = new DataTable();
                    adaptador.Fill(dataTable);

                    cmbPais.DisplayMember = "NombrePais"; // Asigna los nombres de los paises
                    cmbPais.ValueMember = "Idpais"; // Asigna los id segun la tabla Idpais
                    cmbPais.DataSource = dataTable;
                    cmbPais.SelectedIndex = -1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error al cargar la lista de paises: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

            int idPais = Convert.ToInt32(cmbPais.SelectedValue);

            string sql = @"
             INSERT INTO Usuario
             VALUES
             (@NombreUsuario, @FechaNac, @Hashcontrasena, @CorreoElectronico, @FechaRegistro, @idpais, 1)";

            try
            {
                using (SqlConnection conexion = cadConexion.CrearConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@FechaNac", dtpFechaNac.Value.Date);
                        cmd.Parameters.AddWithValue("@Hashcontrasena", txtContrasenia.Text);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Today);
                        cmd.Parameters.AddWithValue("@Idpais", idPais);

                        conexion.Open();
                        cmd.ExecuteNonQuery(); // Ejecuta la orden en SQL
                        MessageBox.Show("Registro exitoso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message,
                    "Error SQL",
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
            string sql = @" 
                SELECT u.IdUsuario, u.NombreUsuario, u.FechaNac, u.CorreoElectronico, u.FechaRegistro, d.NombrePais, u.EstadoCuenta 
                FROM Usuario u 
                INNER JOIN Dispopais d ON u.Idpais = d.Idpais 
                ORDER BY u.NombreUsuario;";

            using (SqlConnection conexion = cadConexion.CrearConexion())
            using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvRegistros.DataSource = tabla;

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
