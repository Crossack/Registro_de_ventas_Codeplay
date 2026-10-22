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
    public partial class RecuperarContraseña : Form
    {
        private readonly LoginNegocios loginNegocios = new LoginNegocios();
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnRecuperarPassword_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string NombreUsuario = txtUsuario.Text.Trim();

            if (string.IsNullOrEmpty(NombreUsuario)) 
            {
                MessageBox.Show("Por favor, ingrese su nombre de usuario", 
                    "Aviso", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

           
            LoginUsuario? usuario = loginNegocios.CargarLoginUsuario(NombreUsuario);

            if (usuario is null )
            {
                MessageBox.Show("El usuario no existe, Intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lblPregunta.Text = usuario.Pregunta;
            
        }
    }
}
