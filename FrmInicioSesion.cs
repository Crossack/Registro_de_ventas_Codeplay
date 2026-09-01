using Microsoft.Data.SqlClient;
using Registro_de_ventas_Codeplay.Sql;

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
            if (txtUsuario.Text == "Crossack" && txtContraseña.Text == "hola1234")
            {
                MessageBox.Show(
                    "Bienvenido Crossack :)",
                    "Inicio de sesion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (txtUsuario.Text == "ProNoobMaster10" && txtContraseña.Text == "soypro10")
            {
                MessageBox.Show(
                    "Bienvenido ProNoobMaster10, activando modo pro hacker",
                    "Inicio de sesion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseñas incorrectas!",
                    "Inicio de sesion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
