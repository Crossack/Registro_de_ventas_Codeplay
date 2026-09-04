using Microsoft.Data.SqlClient;
using Registro_de_ventas_Codeplay.Sql;
using Registro_de_ventas_Codeplay.Classes;
using System.Drawing;

namespace Registro_de_ventas_Codeplay
{
    public partial class FrmInicioSesion : Form
    {
        private bool verContraseña = false;
        private Conexion db = new Conexion();

        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = db.CrearConexion())
                {
                    conexion.Open();
                    MessageBox.Show(
                        "¡Conexión exitosa a SQL Server!",
                        "Estado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message,
                    "Error de SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnVerContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = verContraseña;
            verContraseña = !verContraseña;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = @"SELECT u.IdUsuario, u.NombreUsuario, r.Nombre AS Rol 
                 FROM LoginUsuarios u 
                 INNER JOIN Roles r ON u.IdRol = r.IdRol 
                 WHERE u.NombreUsuario = @usuario AND u.PasswordHash = @password";

            using (SqlConnection conexion = db.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtContraseña.Text); // Idealmente con hash
                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        SesionActiva.IdUsuario = reader.GetInt32(0);
                        SesionActiva.NombreUsuario = reader.GetString(1);
                        SesionActiva.RolUsuario = reader.GetString(2);

                        MessageBox.Show(
                            $"Bienvenido {SesionActiva.NombreUsuario} :)",
                            "Inicio de sesion exitoso",
                            MessageBoxButtons.OK);

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Credenciales inválidas.",
                            "Error al iniciar sesion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtContraseña.Clear();
                        txtContraseña.Focus();
                    }
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LnkContraseña_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "En construccion!",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
