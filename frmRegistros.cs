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
namespace Registro_de_ventas_Codeplay
{
    public partial class frmRegistros : Form
    {
        private Conexion cadConexion = new Conexion();
        public frmRegistros()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string sql = @"
             INSERT INTO Usuario
             VALUES
             (@NombreUsuario, @FechaNac, @Hashcontrasena, @CorreoElectronico, @FechaRegistro, @idpais, 1)";
            if (!ValidarDatos())
            {
                return;
            }
            using (SqlConnection conexion = cadConexion.CrearConexion())

            {
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@FechaNac", dtpFechaNac.Value.Date);
                    cmd.Parameters.AddWithValue("@Hashcontrasena", txtContrasenia.Text);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Today);
                    cmd.Parameters.AddWithValue("@Idpais", int.Parse(txtPais.Text));

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();

                }

            }
            CargarDatos();
        }


        private bool ValidarDatos()
        {
            try
            {
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

                if (string.IsNullOrEmpty(txtPais.Text))
                {
                    MessageBox.Show("El Pais es obligatorio");
                    return false;
                }

                if (string.IsNullOrEmpty(txtContrasenia.Text))
                {
                    MessageBox.Show("La contraseña es obligatoria");
                    return false;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no se procesaron correctamente");
                return false;
            }
            return true;
        }

        private void LimpiarFormulario()
        {
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtPais.Clear();
            txtUsuario.Focus();
        }

        private void CargarDatos()
        {
            string sql = @" 
                SELECT IdUsuario, NombreUsuario, FechaNac, CorreoElectronico, FechaRegistro, IdPais, EstadoCuenta
                FROM Usuario 
                ORDER BY NombreUsuario;";

            using (SqlConnection conexion = cadConexion.CrearConexion())
            using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvRegistros.DataSource = tabla;

            }


        }

        private void frmRegistros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
