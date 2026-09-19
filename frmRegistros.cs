using Microsoft.Data.SqlClient;
using ReaLTaiizor.Controls;
using Registro_de_ventas_Codeplay.Classes;
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

namespace Registro_de_ventas_Codeplay
{
    public partial class frmRegistros : Form
    {
        // Instancia de la conexion para gestionar la BD
        private Conexion cadConexion = new Conexion();

        //Datos para los colores de la ventana principal

        private readonly Color ColorFondo = ColorTranslator.FromHtml("#f1f2fc");
        private readonly Color ColorPrimario = ColorTranslator.FromHtml("#374ad1");
        private readonly Color ColorSecundario = ColorTranslator.FromHtml("#e79d94");
        private readonly Color ColorTexto = ColorTranslator.FromHtml("#07091f");
        private readonly Color ColorBlanco = Color.White;
            
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
        
            txtCorreo.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
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

            lblBienvenida.Text = $"{SesionActiva.NombreUsuario} ({SesionActiva.RolUsuario})";
            if (SesionActiva.RolUsuario == "Lector")
            {
                grpRegistroEst.Enabled = false;
            }

            AplicarCoolores();
            ConfigurarTarjetaRegistro();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Desea cerrar el programa?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                Close();
            }

        }

        private void AplicarCoolores() //Aplica los colores automaticamente
        {
            this.BackColor = ColorFondo;
            grpRegistroEst.BackColor = ColorBlanco;
            grpRegistroEst.ForeColor = ColorTexto;

            txtUsuario.BackColor = ColorBlanco;
            txtUsuario.ForeColor = ColorTexto;
            txtContrasenia.BackColor = ColorBlanco;
            txtContrasenia.ForeColor = ColorTexto;
            txtCorreo.BackColor = ColorBlanco;
            txtCorreo.ForeColor = ColorTexto;
            cmbPais.BackColor = ColorBlanco;
            cmbPais.ForeColor = ColorTexto;

            btnRegistrar.BackColor = ColorPrimario;
            btnRegistrar.ForeColor = ColorBlanco;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.FlatAppearance.BorderSize = 0;

            btnSalir.BackColor = ColorSecundario;
            btnSalir.ForeColor = ColorTexto;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;

            dgvRegistros.BackgroundColor = ColorBlanco;
            dgvRegistros.BorderStyle = BorderStyle.None;
            dgvRegistros.DefaultCellStyle.BackColor = ColorBlanco;
            dgvRegistros.DefaultCellStyle.ForeColor = ColorTexto;
            dgvRegistros.DefaultCellStyle.SelectionBackColor = ColorPrimario;
            dgvRegistros.DefaultCellStyle.SelectionForeColor = ColorBlanco;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = ColorPrimario;
            dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor = ColorBlanco;

            /////////////
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.ScrollBars = ScrollBars.Vertical;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2563EB");
            dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            dgvRegistros.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            dgvRegistros.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#3B82F6");
            dgvRegistros.DefaultCellStyle.SelectionForeColor = Color.White;


            /////////////////////// Fuentes
            
            Font fontTitulo = new Font("Segoe UI", 15f, FontStyle.Bold);
            Font fontLabels = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold);
            Font fontInputs = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            Font fontManager = new Font("Segoe UI", 9f, FontStyle.Regular);

            Color colorTextoPrincipal = ColorTranslator.FromHtml("#1E293B"); // Slate oscuro
            Color colorTextoSecundario = ColorTranslator.FromHtml("#64748B"); // Gris suave

            lblTitulo.Font = fontTitulo;
            lblTitulo.ForeColor = colorTextoPrincipal;

            lblUsuario.Font = fontLabels;
            lblUsuario.ForeColor = colorTextoSecundario;

            lblcontrasena.Font = fontLabels;
            lblcontrasena.ForeColor = colorTextoSecundario;

            fechanac.Font = fontLabels;
            fechanac.ForeColor = colorTextoSecundario;

            lblemail.Font = fontLabels;
            lblemail.ForeColor = colorTextoSecundario;

            lblpais.Font = fontLabels;
            lblpais.ForeColor = colorTextoSecundario;

            lblBienvenida.Font = fontManager;
            lblBienvenida.ForeColor = colorTextoSecundario;

            dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvRegistros.DefaultCellStyle.Font = fontInputs;

        

        }

        private void ConfigurarTarjetaRegistro()
        {

            // 1. Fondo de la tarjeta y del formulario
            this.BackColor = ColorTranslator.FromHtml("#F1F5F9");
            grpRegistroEst.BackColor = Color.White;

            // 2. Definir fuente y colores
            Font fontLabel = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
            Color colorTextoLabels = ColorTranslator.FromHtml("#475569"); // Gris pizarra elegante
            Color bordeInputs = ColorTranslator.FromHtml("#CBD5E1");

            // 3. Configurar etiquetas PoisonLabel (Obligatorio UseCustom)
            PoisonLabel[] labels = { lblUsuario, lblcontrasena, fechanac, lblemail, lblpais };
            foreach (var lbl in labels)
            {
                if (lbl != null)
                {
                    lbl.UseCustomForeColor = true;
                    lbl.UseCustomFont = true;
                    lbl.Font = fontLabel;
                    lbl.ForeColor = colorTextoLabels;
                }
            }

            // 4. Campos de texto
            txtUsuario.BorderColor = bordeInputs;
            txtUsuario.CustomBGColor = Color.White;

            txtContrasenia.BorderColor = bordeInputs;
            txtContrasenia.CustomBGColor = Color.White;
            txtContrasenia.UseSystemPasswordChar = true;

            txtCorreo.BorderColor = bordeInputs;
            txtCorreo.CustomBGColor = Color.White;

            // 5. Selector de fecha
            dtpFechaNac.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            dtpFechaNac.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;

            // 6. Texto de usuario inferior
            lblBienvenida.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            lblBienvenida.ForeColor = ColorTranslator.FromHtml("#64748B");
        }

    }
}
