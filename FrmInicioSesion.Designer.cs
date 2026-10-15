namespace Registro_de_ventas_Codeplay
{
    partial class FrmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            lnkContraseña = new LinkLabel();
            gbxLogin = new ReaLTaiizor.Controls.MaterialCard();
            lblTituloLogin = new ReaLTaiizor.Controls.PoisonLabel();
            lblContraseña = new ReaLTaiizor.Controls.PoisonLabel();
            lblNombUsuario = new ReaLTaiizor.Controls.PoisonLabel();
            btnSalir = new ReaLTaiizor.Controls.MaterialButton();
            btnLogin = new ReaLTaiizor.Controls.MaterialButton();
            btnVerContraseña = new FontAwesome.Sharp.IconPictureBox();
            txtContraseña = new ReaLTaiizor.Controls.SmallTextBox();
            txtUsuario = new ReaLTaiizor.Controls.SmallTextBox();
            gbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVerContraseña).BeginInit();
            SuspendLayout();
            // 
            // lnkContraseña
            // 
            lnkContraseña.AutoSize = true;
            lnkContraseña.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkContraseña.Location = new Point(103, 393);
            lnkContraseña.Name = "lnkContraseña";
            lnkContraseña.Size = new Size(161, 14);
            lnkContraseña.TabIndex = 3;
            lnkContraseña.TabStop = true;
            lnkContraseña.Text = "¿Olvidé mi contraseña?\r\n";
            lnkContraseña.Click += LnkContraseña_Click;
            // 
            // gbxLogin
            // 
            gbxLogin.BackColor = Color.FromArgb(255, 255, 255);
            gbxLogin.Controls.Add(lblTituloLogin);
            gbxLogin.Controls.Add(lblContraseña);
            gbxLogin.Controls.Add(lnkContraseña);
            gbxLogin.Controls.Add(lblNombUsuario);
            gbxLogin.Controls.Add(btnSalir);
            gbxLogin.Controls.Add(btnLogin);
            gbxLogin.Controls.Add(btnVerContraseña);
            gbxLogin.Controls.Add(txtContraseña);
            gbxLogin.Controls.Add(txtUsuario);
            gbxLogin.Depth = 0;
            gbxLogin.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxLogin.ForeColor = Color.FromArgb(222, 0, 0, 0);
            gbxLogin.Location = new Point(3, -2);
            gbxLogin.Margin = new Padding(17, 14, 17, 14);
            gbxLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Padding = new Padding(17, 14, 17, 14);
            gbxLogin.Size = new Size(405, 425);
            gbxLogin.TabIndex = 4;
            gbxLogin.Click += FrmInicioSesion_Load;
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLogin.Location = new Point(157, 30);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(148, 23);
            lblTituloLogin.TabIndex = 8;
            lblTituloLogin.Text = "CODEPLAY";
            lblTituloLogin.UseCustomFont = true;
            lblTituloLogin.UseCustomForeColor = true;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(49, 174);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(88, 17);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "CONTRASEÑA";
            lblContraseña.UseCustomFont = true;
            lblContraseña.UseCustomForeColor = true;
            // 
            // lblNombUsuario
            // 
            lblNombUsuario.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombUsuario.Location = new Point(49, 95);
            lblNombUsuario.Name = "lblNombUsuario";
            lblNombUsuario.Size = new Size(124, 20);
            lblNombUsuario.TabIndex = 5;
            lblNombUsuario.Text = "USUARIO";
            lblNombUsuario.UseCustomBackColor = true;
            lblNombUsuario.UseCustomFont = true;
            lblNombUsuario.UseCustomForeColor = true;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = false;
            btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalir.Depth = 0;
            btnSalir.HighEmphasis = true;
            btnSalir.Icon = null;
            btnSalir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalir.Location = new Point(49, 308);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalir.Name = "btnSalir";
            btnSalir.NoAccentTextColor = Color.Empty;
            btnSalir.Size = new Size(299, 45);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnSalir.UseAccentColor = false;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = Color.FromArgb(0, 240, 255, 0);
            btnLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLogin.Location = new Point(49, 251);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(300, 45);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "INGRESAR";
            btnLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btnVerContraseña
            // 
            btnVerContraseña.BackColor = Color.Transparent;
            btnVerContraseña.Cursor = Cursors.Hand;
            btnVerContraseña.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnVerContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnVerContraseña.IconColor = Color.FromArgb(222, 0, 0, 0);
            btnVerContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerContraseña.IconSize = 28;
            btnVerContraseña.Location = new Point(351, 195);
            btnVerContraseña.Name = "btnVerContraseña";
            btnVerContraseña.Size = new Size(31, 28);
            btnVerContraseña.TabIndex = 2;
            btnVerContraseña.TabStop = false;
            btnVerContraseña.Click += BtnVerContraseña_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.Transparent;
            txtContraseña.BorderColor = Color.FromArgb(180, 180, 180);
            txtContraseña.CustomBGColor = Color.FromArgb(11, 17, 30);
            txtContraseña.Font = new Font("Tahoma", 11F);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(49, 195);
            txtContraseña.MaxLength = 32767;
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.ReadOnly = false;
            txtContraseña.Size = new Size(300, 28);
            txtContraseña.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtContraseña.TabIndex = 2;
            txtContraseña.TextAlignment = HorizontalAlignment.Left;
            txtContraseña.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            txtUsuario.CustomBGColor = Color.FromArgb(11, 17, 30);
            txtUsuario.Font = new Font("Tahoma", 11F);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(48, 116);
            txtUsuario.MaxLength = 32767;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = false;
            txtUsuario.Size = new Size(300, 28);
            txtUsuario.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtUsuario.TabIndex = 1;
            txtUsuario.TextAlignment = HorizontalAlignment.Left;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // FrmInicioSesion
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 424);
            Controls.Add(gbxLogin);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInicioSesion";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO DE SESIÓN";
            Load += FrmInicioSesion_Load;
            gbxLogin.ResumeLayout(false);
            gbxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVerContraseña).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel lnkContraseña;
        private ReaLTaiizor.Controls.MaterialCard gbxLogin;
        private ReaLTaiizor.Controls.SmallTextBox txtContraseña;
        private ReaLTaiizor.Controls.SmallTextBox txtUsuario;
        private FontAwesome.Sharp.IconPictureBox btnVerContraseña;
        private ReaLTaiizor.Controls.MaterialButton btnSalir;
        private ReaLTaiizor.Controls.MaterialButton btnLogin;
        private ReaLTaiizor.Controls.PoisonLabel lblNombUsuario;
        private ReaLTaiizor.Controls.PoisonLabel lblContraseña;
        private ReaLTaiizor.Controls.PoisonLabel lblTituloLogin;
    }
}
