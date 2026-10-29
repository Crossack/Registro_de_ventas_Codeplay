namespace Registro_de_ventas_Codeplay
{
    partial class FrmRecuperacionContraseña
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreUsuario = new ReaLTaiizor.Controls.DungeonTextBox();
            txtRespuestaPregunta = new ReaLTaiizor.Controls.DungeonTextBox();
            grpValidacion = new ReaLTaiizor.Controls.GroupBox();
            btnBuscarUsuario = new ReaLTaiizor.Controls.MoonButton();
            btnValidarUsuario = new ReaLTaiizor.Controls.MaterialButton();
            lblRespuestaPregunta = new ReaLTaiizor.Controls.DungeonLabel();
            lblNombreUsuario = new ReaLTaiizor.Controls.DungeonLabel();
            grpCambioContraseña = new ReaLTaiizor.Controls.GroupBox();
            btnCambiarContraseña = new ReaLTaiizor.Controls.MaterialButton();
            txtContraseña = new ReaLTaiizor.Controls.DungeonTextBox();
            lblContraseña = new ReaLTaiizor.Controls.DungeonLabel();
            btnSalir = new ReaLTaiizor.Controls.CyberButton();
            grpValidacion.SuspendLayout();
            grpCambioContraseña.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.Transparent;
            txtNombreUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            txtNombreUsuario.EdgeColor = Color.White;
            txtNombreUsuario.Font = new Font("Tahoma", 11F);
            txtNombreUsuario.ForeColor = Color.DimGray;
            txtNombreUsuario.Location = new Point(126, 73);
            txtNombreUsuario.MaxLength = 32767;
            txtNombreUsuario.Multiline = false;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = false;
            txtNombreUsuario.Size = new Size(186, 28);
            txtNombreUsuario.TabIndex = 0;
            txtNombreUsuario.TextAlignment = HorizontalAlignment.Left;
            txtNombreUsuario.UseSystemPasswordChar = false;
            txtNombreUsuario.Enter += TxtNombreUsuario_Enter;
            // 
            // txtRespuestaPregunta
            // 
            txtRespuestaPregunta.BackColor = Color.Transparent;
            txtRespuestaPregunta.BorderColor = Color.FromArgb(180, 180, 180);
            txtRespuestaPregunta.EdgeColor = Color.White;
            txtRespuestaPregunta.Enabled = false;
            txtRespuestaPregunta.Font = new Font("Tahoma", 11F);
            txtRespuestaPregunta.ForeColor = Color.DimGray;
            txtRespuestaPregunta.Location = new Point(126, 134);
            txtRespuestaPregunta.MaxLength = 32767;
            txtRespuestaPregunta.Multiline = false;
            txtRespuestaPregunta.Name = "txtRespuestaPregunta";
            txtRespuestaPregunta.ReadOnly = false;
            txtRespuestaPregunta.Size = new Size(186, 28);
            txtRespuestaPregunta.TabIndex = 1;
            txtRespuestaPregunta.TextAlignment = HorizontalAlignment.Left;
            txtRespuestaPregunta.UseSystemPasswordChar = false;
            // 
            // grpValidacion
            // 
            grpValidacion.BackColor = Color.Transparent;
            grpValidacion.BackGColor = Color.Azure;
            grpValidacion.BaseColor = Color.Transparent;
            grpValidacion.BorderColorG = Color.RoyalBlue;
            grpValidacion.BorderColorH = Color.RoyalBlue;
            grpValidacion.Controls.Add(btnBuscarUsuario);
            grpValidacion.Controls.Add(btnValidarUsuario);
            grpValidacion.Controls.Add(lblRespuestaPregunta);
            grpValidacion.Controls.Add(lblNombreUsuario);
            grpValidacion.Controls.Add(txtNombreUsuario);
            grpValidacion.Controls.Add(txtRespuestaPregunta);
            grpValidacion.Dock = DockStyle.Top;
            grpValidacion.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpValidacion.ForeColor = Color.FromArgb(53, 53, 53);
            grpValidacion.HeaderColor = Color.DeepSkyBlue;
            grpValidacion.Location = new Point(0, 0);
            grpValidacion.MinimumSize = new Size(136, 50);
            grpValidacion.Name = "grpValidacion";
            grpValidacion.Padding = new Padding(5, 28, 5, 5);
            grpValidacion.Size = new Size(434, 252);
            grpValidacion.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            grpValidacion.TabIndex = 2;
            grpValidacion.Text = "Confirme su identidad";
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Customization = "/////9PT0//w8PD/gICA/w==";
            btnBuscarUsuario.Font = new Font("Segoe UI", 9F);
            btnBuscarUsuario.Image = null;
            btnBuscarUsuario.Location = new Point(325, 74);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.NoRounding = false;
            btnBuscarUsuario.Size = new Size(70, 26);
            btnBuscarUsuario.TabIndex = 5;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.Transparent = false;
            btnBuscarUsuario.Click += BtnBuscarUsuario_Click;
            // 
            // btnValidarUsuario
            // 
            btnValidarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnValidarUsuario.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnValidarUsuario.Depth = 0;
            btnValidarUsuario.Enabled = false;
            btnValidarUsuario.HighEmphasis = true;
            btnValidarUsuario.Icon = null;
            btnValidarUsuario.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnValidarUsuario.Location = new Point(177, 195);
            btnValidarUsuario.Margin = new Padding(4, 6, 4, 6);
            btnValidarUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnValidarUsuario.Name = "btnValidarUsuario";
            btnValidarUsuario.NoAccentTextColor = Color.Empty;
            btnValidarUsuario.Size = new Size(81, 36);
            btnValidarUsuario.TabIndex = 4;
            btnValidarUsuario.Text = "Validar";
            btnValidarUsuario.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnValidarUsuario.UseAccentColor = false;
            btnValidarUsuario.UseVisualStyleBackColor = true;
            btnValidarUsuario.Click += BtnValidarUsuario_Click;
            // 
            // lblRespuestaPregunta
            // 
            lblRespuestaPregunta.BackColor = Color.Transparent;
            lblRespuestaPregunta.Font = new Font("Segoe UI", 11F);
            lblRespuestaPregunta.ForeColor = Color.FromArgb(76, 76, 77);
            lblRespuestaPregunta.Location = new Point(5, 111);
            lblRespuestaPregunta.Name = "lblRespuestaPregunta";
            lblRespuestaPregunta.Size = new Size(423, 23);
            lblRespuestaPregunta.TabIndex = 3;
            lblRespuestaPregunta.Text = "text : pregunta";
            lblRespuestaPregunta.TextAlign = ContentAlignment.TopCenter;
            lblRespuestaPregunta.Visible = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Segoe UI", 11F);
            lblNombreUsuario.ForeColor = Color.FromArgb(76, 76, 77);
            lblNombreUsuario.Location = new Point(126, 50);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(139, 20);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // grpCambioContraseña
            // 
            grpCambioContraseña.BackColor = Color.Transparent;
            grpCambioContraseña.BackGColor = Color.Azure;
            grpCambioContraseña.BaseColor = Color.Transparent;
            grpCambioContraseña.BorderColorG = Color.RoyalBlue;
            grpCambioContraseña.BorderColorH = Color.RoyalBlue;
            grpCambioContraseña.Controls.Add(btnCambiarContraseña);
            grpCambioContraseña.Controls.Add(txtContraseña);
            grpCambioContraseña.Controls.Add(lblContraseña);
            grpCambioContraseña.Enabled = false;
            grpCambioContraseña.Font = new Font("Tahoma", 9F);
            grpCambioContraseña.ForeColor = Color.FromArgb(53, 53, 53);
            grpCambioContraseña.HeaderColor = Color.DodgerBlue;
            grpCambioContraseña.Location = new Point(0, 311);
            grpCambioContraseña.MinimumSize = new Size(136, 50);
            grpCambioContraseña.Name = "grpCambioContraseña";
            grpCambioContraseña.Padding = new Padding(5, 28, 5, 5);
            grpCambioContraseña.Size = new Size(434, 188);
            grpCambioContraseña.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            grpCambioContraseña.TabIndex = 3;
            grpCambioContraseña.Text = "Ingrese su nueva contraseña";
            grpCambioContraseña.Visible = false;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCambiarContraseña.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCambiarContraseña.Depth = 0;
            btnCambiarContraseña.HighEmphasis = true;
            btnCambiarContraseña.Icon = null;
            btnCambiarContraseña.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCambiarContraseña.Location = new Point(174, 126);
            btnCambiarContraseña.Margin = new Padding(4, 6, 4, 6);
            btnCambiarContraseña.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.NoAccentTextColor = Color.Empty;
            btnCambiarContraseña.Size = new Size(86, 36);
            btnCambiarContraseña.TabIndex = 2;
            btnCambiarContraseña.Text = "Cambiar";
            btnCambiarContraseña.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCambiarContraseña.UseAccentColor = false;
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += BtnCambiarContraseña_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.Transparent;
            txtContraseña.BorderColor = Color.FromArgb(180, 180, 180);
            txtContraseña.EdgeColor = Color.White;
            txtContraseña.Font = new Font("Tahoma", 11F);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(106, 70);
            txtContraseña.MaxLength = 32767;
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.ReadOnly = false;
            txtContraseña.Size = new Size(222, 28);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextAlignment = HorizontalAlignment.Left;
            txtContraseña.UseSystemPasswordChar = false;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Segoe UI", 11F);
            lblContraseña.ForeColor = Color.FromArgb(76, 76, 77);
            lblContraseña.Location = new Point(106, 47);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(129, 20);
            lblContraseña.TabIndex = 0;
            lblContraseña.Text = "Nueva Contraseña";
            // 
            // btnSalir
            // 
            btnSalir.Alpha = 20;
            btnSalir.BackColor = Color.Transparent;
            btnSalir.Background = false;
            btnSalir.Background_WidthPen = 4F;
            btnSalir.BackgroundPen = true;
            btnSalir.ColorBackground = Color.White;
            btnSalir.ColorBackground_1 = Color.White;
            btnSalir.ColorBackground_2 = Color.White;
            btnSalir.ColorBackground_Pen = Color.RoyalBlue;
            btnSalir.ColorLighting = Color.RoyalBlue;
            btnSalir.ColorPen_1 = Color.White;
            btnSalir.ColorPen_2 = Color.White;
            btnSalir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSalir.Effect_1 = true;
            btnSalir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSalir.Effect_1_Transparency = 25;
            btnSalir.Effect_2 = true;
            btnSalir.Effect_2_ColorBackground = Color.MidnightBlue;
            btnSalir.Effect_2_Transparency = 20;
            btnSalir.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.RoyalBlue;
            btnSalir.Lighting = false;
            btnSalir.LinearGradient_Background = false;
            btnSalir.LinearGradientPen = false;
            btnSalir.Location = new Point(152, 261);
            btnSalir.Name = "btnSalir";
            btnSalir.PenWidth = 15;
            btnSalir.Rounding = true;
            btnSalir.RoundingInt = 70;
            btnSalir.Size = new Size(130, 44);
            btnSalir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSalir.TabIndex = 4;
            btnSalir.Tag = "Cyber";
            btnSalir.TextButton = "SALIR";
            btnSalir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSalir.Timer_Effect_1 = 5;
            btnSalir.Timer_RGB = 300;
            btnSalir.Click += BtnSalir_Click;
            // 
            // FrmRecuperacionContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 313);
            Controls.Add(btnSalir);
            Controls.Add(grpCambioContraseña);
            Controls.Add(grpValidacion);
            Name = "FrmRecuperacionContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recupererar Contraseña";
            Load += FrmRecuperacionContraseña_Load;
            grpValidacion.ResumeLayout(false);
            grpValidacion.PerformLayout();
            grpCambioContraseña.ResumeLayout(false);
            grpCambioContraseña.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox txtNombreUsuario;
        private ReaLTaiizor.Controls.DungeonTextBox txtRespuestaPregunta;
        private ReaLTaiizor.Controls.GroupBox grpValidacion;
        private ReaLTaiizor.Controls.MaterialButton btnValidarUsuario;
        private ReaLTaiizor.Controls.DungeonLabel lblRespuestaPregunta;
        private ReaLTaiizor.Controls.DungeonLabel lblNombreUsuario;
        private ReaLTaiizor.Controls.MoonButton btnBuscarUsuario;
        private ReaLTaiizor.Controls.GroupBox grpCambioContraseña;
        private ReaLTaiizor.Controls.DungeonLabel lblContraseña;
        private ReaLTaiizor.Controls.MaterialButton btnCambiarContraseña;
        private ReaLTaiizor.Controls.DungeonTextBox txtContraseña;
        private ReaLTaiizor.Controls.CyberButton btnSalir;
    }
}