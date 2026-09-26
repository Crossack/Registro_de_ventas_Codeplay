using System.Drawing;
using Registro_de_ventas_Codeplay.Models;
using Registro_de_ventas_Codeplay.Business;

namespace Registro_de_ventas_Codeplay
{
    public partial class FrmInicioSesion : Form
    {
        private bool verContraseña = false;
        private readonly LoginNegocios loginNegocios = new LoginNegocios();

        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnVerContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = verContraseña;
            verContraseña = !verContraseña;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool acceso = loginNegocios.ValidarSesion(txtUsuario.Text.Trim(), txtContraseña.Text);

                if (acceso)
                {
                    MessageBox.Show(
                       $"Bienvenido {SesionActiva.NombreUsuario} :)",
                       "Inicio de sesion exitoso",
                       MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Credenciales invalidas",
                        "Error al iniciar sesion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    txtContraseña.Focus();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesion: " + ex.Message,
                    "Error",
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
