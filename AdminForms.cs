using Guna.UI2.WinForms;
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
using System.Runtime.InteropServices;

namespace Registro_de_ventas_Codeplay
{
    public partial class AdminForms : Form
    {
        public AdminForms()
        {
            InitializeComponent();

        }

        private void contenedorJugadores_Paint(object sender, PaintEventArgs e)
        {
            //  Este se me presiono por error xd 
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConfigurarInterfazAdmin();
                CargarJugadoresPrueba();
            }
        }

        private void OrdenarMenuLateral()
        {

            pnlAdmin.BringToFront();
            btnRegistrarUsers.BringToFront();
            btnReportes.BringToFront();
            pnlSubReportes.BringToFront();
        }



        private void ConfigurarInterfazAdmin()
        {

            bool esAdmin = string.Equals(SesionActiva.RolUsuario?.Trim(), "Admin", StringComparison.OrdinalIgnoreCase) ||
                           string.Equals(SesionActiva.RolUsuario?.Trim(), "Administrador", StringComparison.OrdinalIgnoreCase);


            lblSaludo.Text = $"BIENVENIDO, {SesionActiva.NombreUsuario}";
            btnBadgeRol.Text = esAdmin ? "ADMIN" : (SesionActiva.RolUsuario?.ToUpper() ?? "USER");
            btnBadgeRol.FillColor = esAdmin ? Color.FromArgb(0, 240, 255) : Color.Gray;
            btnBadgeRol.ForeColor = esAdmin ? Color.FromArgb(7, 10, 19) : Color.White;


            pnlAdmin.Visible = esAdmin;
            btnRegistrarUsers.Visible = esAdmin;
            btnReportes.Visible = esAdmin;
            pnlSubReportes.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pnlSubReportes.Visible = !pnlSubReportes.Visible;

            if (pnlSubReportes.Visible)
            {

                pnlSubReportes.BringToFront();
            }
        }

        private void CargarJugadoresPrueba()
        {
            contenedorJugadores.Controls.Clear();


            AgregarTarjetaJugador("Sans", "20 H jugadas", "40000 Copas", "2 Derrotas", true);
            AgregarTarjetaJugador("Box", "120 H jugadas", "450 Copas", "14 Derrotas", true);
        }

        private void AgregarTarjetaJugador(string nombre, string horas, string copas, string derrotas, bool activo)
        {
            Color colorFondoTarjeta = Color.FromArgb(19, 27, 46);


            Guna2Panel tarjeta = new Guna2Panel
            {
                Size = new Size(760, 65),
                BorderRadius = 25,
                FillColor = colorFondoTarjeta,
                BackColor = Color.Transparent,
                UseTransparentBackground = true,
                BorderColor = Color.FromArgb(0, 240, 255),
                BorderThickness = 1,
                Margin = new Padding(0, 0, 0, 15)
            };


            Label lblNombre = CrearColumnaTexto(nombre, new Point(25, 22), Color.FromArgb(0, 240, 255), colorFondoTarjeta, true);
            Label lblHoras = CrearColumnaTexto(horas, new Point(115, 22), Color.White, colorFondoTarjeta, false);
            Label lblCopas = CrearColumnaTexto(copas, new Point(235, 22), Color.White, colorFondoTarjeta, false);
            Label lblDerrotas = CrearColumnaTexto(derrotas, new Point(350, 22), Color.White, colorFondoTarjeta, false);


            Guna2Button btnActivo = CrearBotonAccion(activo ? "Activo" : "Inactivo", Color.FromArgb(16, 185, 129), new Point(455, 15), colorFondoTarjeta);

            Guna2Button btnReportar = CrearBotonAccion("Reportar", Color.FromArgb(245, 158, 11), new Point(555, 15), colorFondoTarjeta);
            btnReportar.Click += (s, e) => MessageBox.Show($"Reportando a {nombre}...");

            Guna2Button btnBanear = CrearBotonAccion("Banear", Color.FromArgb(239, 68, 68), new Point(655, 15), colorFondoTarjeta);
            btnBanear.Click += (s, e) => MessageBox.Show($"Usuario {nombre} baneado.");


            tarjeta.Controls.Add(lblNombre);
            tarjeta.Controls.Add(lblHoras);
            tarjeta.Controls.Add(lblCopas);
            tarjeta.Controls.Add(lblDerrotas);
            tarjeta.Controls.Add(btnActivo);
            tarjeta.Controls.Add(btnReportar);
            tarjeta.Controls.Add(btnBanear);

            contenedorJugadores.Controls.Add(tarjeta);
        }

        private Label CrearColumnaTexto(string texto, Point ubicacion, Color colorLetra, Color colorFondo, bool negrita)
        {
            return new Label
            {
                Text = texto,
                ForeColor = colorLetra,
                BackColor = colorFondo,
                Font = new Font("Segoe UI Semibold", 10f, negrita ? FontStyle.Bold : FontStyle.Regular),
                AutoSize = true,
                Location = ubicacion
            };
        }


        private Guna2Button CrearBotonAccion(string texto, Color colorRelleno, Point ubicacion, Color colorFondoTarjeta)
        {
            return new Guna2Button
            {
                Text = texto,
                Size = new Size(98, 35),
                BorderRadius = 17,
                FillColor = colorRelleno,
                BackColor = colorFondoTarjeta,
                UseTransparentBackground = true,
                ForeColor = Color.FromArgb(7, 10, 19),
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Center,
                TextOffset = new Point(0, 0),
                Location = ubicacion,
                Cursor = Cursors.Hand
            };
        }

        private Guna2Button CrearBotonAccion(string texto, Color colorFondo, Point ubicacion)
        {
            return new Guna2Button
            {
                Text = texto,
                Size = new Size(95, 35),
                BorderRadius = 17,
                FillColor = colorFondo,
                ForeColor = Color.FromArgb(7, 10, 19),
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                Location = ubicacion,
                Cursor = Cursors.Hand
            };
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SesionActiva.Cerrar();

            FrmInicioSesion login = new FrmInicioSesion();
            login.Show();
            this.Dispose();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            contenedorJugadores.Visible = false;


            dgvEstadisticas.Visible = true;
            dgvEstadisticas.BringToFront();

            CargarDatosEstadisticas();
        }

        private void CargarDatosEstadisticas()
        {
            // Wsre es para cargar los daros en gridviewm pero ahi ve si lo haces de otra forma xd
        }


        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            dgvEstadisticas.Visible = false;
            contenedorJugadores.Visible = true;
            contenedorJugadores.BringToFront();
        }

      

        private void btnRegistrarUsers_Click(object sender, EventArgs e)
        {
            // Este boton es para que te lleve al formulario de registro por si quieres agregar usuarios
        }



    }


}