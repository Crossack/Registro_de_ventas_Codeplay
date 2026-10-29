using System.Drawing;
using Registro_de_ventas_Codeplay.Models;
using Registro_de_ventas_Codeplay.Business;

namespace Registro_de_ventas_Codeplay
{
    public partial class FrmInicioSesion : Form
    {
        private bool verContraseña = false;
        private CancellationTokenSource? cts;
        private readonly LoginNegocios loginNegocios = new LoginNegocios();

        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            verContraseña = false;
        }

        private void BtnVerContraseña_Click(object sender, EventArgs e)
        {
            //txtContraseña.UseSystemPasswordChar = verContraseña;
            //verContraseña = !verContraseña;

            verContraseña = !verContraseña;
            txtContraseña.UseSystemPasswordChar = !verContraseña;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnLogin.Text = "Procesando...";
            cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            
            try
            {
                bool acceso = await loginNegocios.ValidarSesionAsync(txtUsuario.Text.Trim(), txtContraseña.Text, cts.Token);

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
                    txtContraseña.Text = "";
                    txtContraseña.Focus();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show(
                    "Tiempo de espera del servidor agotado. Por favor revise la base de datos",
                    "Tiempo de espera agotado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesion: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cts.Dispose();
                cts = null;
                btnLogin.Enabled = true;
                btnLogin.Text = "INGRESAR";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LnkContraseña_Click(object sender, EventArgs e)
        {
            using (FrmRecuperacionContraseña frmRecuperacionContraseña = new())
            {
                frmRecuperacionContraseña.ShowDialog();
            }
        }
    }
}
