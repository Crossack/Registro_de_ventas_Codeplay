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
        // Unicamente de relleno!
        public class JugadorMock
        {
            public string? Usuario { get; set; }
            public int HorasJugadas { get; set; }
            public int Diamantes { get; set; }
            public string? Estado { get; set; }
        }

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

        private void FrmPanelCodeplay_Load(object sender, EventArgs e)
        {
            VincularMetodos();
            pnlSubMenuReportes.Visible = false;
            
            // Hola Mundo!
            lblBienvenida.Text =
                $"Bienvenido {SesionActiva.NombreUsuario} | {SesionActiva.RolUsuario}";
            CargarJugadoresPrueba();
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
        private void CargarJugadoresPrueba()
        {
            var listaJugadores = new List<JugadorMock>
            {
                new JugadorMock { Usuario = "ShadowHunter", HorasJugadas = 142, Diamantes = 850, Estado = "Activo" },
                new JugadorMock { Usuario = "Valkyrie99", HorasJugadas = 320, Diamantes = 2400, Estado = "Activo" },
                new JugadorMock { Usuario = "PixelKnight", HorasJugadas = 45, Diamantes = 120, Estado = "Suspendido" },
                new JugadorMock { Usuario = "CyberDragon", HorasJugadas = 510, Diamantes = 6150, Estado = "Activo" },
                new JugadorMock { Usuario = "GlitchMaster", HorasJugadas = 88, Diamantes = 0, Estado = "Suspendido" }
            };

            dgvListaUsuarios.DataSource = null;
            dgvListaUsuarios.DataSource = listaJugadores;

            // Ajustes visuales opcionales para la grilla
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaUsuarios.ReadOnly = true;
        }
    }
}
