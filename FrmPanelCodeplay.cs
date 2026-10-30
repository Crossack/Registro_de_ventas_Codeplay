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
    public partial class FrmPanelCodeplay : Form
    {
        private readonly UsuarioNegocio _usuarioNegocio = new();

        public FrmPanelCodeplay()
        {
            InitializeComponent();
        }

        private void VincularMetodos()
        {
            mbtnListaUsuarios.Click += BtnOpcionListaUsuario_Click;
            mbtnRegistroUsuarios.Click += BtnMenuRegistroUsuarios_Click;
            mbtnEstadisticas.Click += BtnOpcionEstadistica_Click;
            mbtnMenuReportes.Click += BtnOpcionReportes_Click;
            mbtnSalir.Click += BtnSalir_Click;
        }

        private async void FrmPanelCodeplay_Load(object sender, EventArgs e)
        {
            VincularMetodos();
            pnlSubMenuReportes.Visible = false;
            
            // Hola Mundo!
            lblBienvenida.Text =
                $"Bienvenido {SesionActiva.NombreUsuario} | {SesionActiva.RolUsuario}";
            await CargarJugadores();
        }

        private void BtnOpcionListaUsuario_Click(object sender, EventArgs e)
        {
            pnlMenuListaUsuario.Visible = true;
            pnlMenuEstadisticas.Visible = false;
        }

        private void BtnMenuRegistroUsuarios_Click(object sender, EventArgs e)
        {
            Hide();
            using (frmRegistros registros = new frmRegistros())
            {
                registros.ShowDialog();
            }
            Show();
        }

        private void BtnOpcionEstadistica_Click(object sender, EventArgs e)
        {
            pnlMenuEstadisticas.Visible = true;
            pnlMenuEstadisticas.Dock = DockStyle.Fill;
            pnlMenuListaUsuario.Visible = false;
        }

        private void BtnOpcionReportes_Click(object sender, EventArgs e)
        {
            pnlSubMenuReportes.Visible = !pnlSubMenuReportes.Visible;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            SesionActiva.Cerrar();
            Close();
        }

        // Unicamente para pruebas y de relleno!
        private async Task CargarJugadores()
        {
            List<Usuario> listaJugadores = await _usuarioNegocio.SolicitarListaUsuariosAsync();

            dgvListaUsuarios.DataSource = listaJugadores;

            // Ajustes visuales opcionales para la grilla
            dgvListaUsuarios.Columns["Contraseña"].Visible = false;
            dgvListaUsuarios.Columns["RowVersion"].Visible = false;
            dgvListaUsuarios.Columns["IdPais"].Visible = false;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaUsuarios.ReadOnly = true;
        }
    }
}
