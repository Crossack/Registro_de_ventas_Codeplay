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
            gbxLogin = new GroupBox();
            btnVerContraseña = new Button();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            lblNombUsuario = new Label();
            btnLogin = new Button();
            btnSalir = new Button();
            lnkContraseña = new LinkLabel();
            gbxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbxLogin
            // 
            gbxLogin.Controls.Add(btnVerContraseña);
            gbxLogin.Controls.Add(txtContraseña);
            gbxLogin.Controls.Add(lblContraseña);
            gbxLogin.Controls.Add(txtUsuario);
            gbxLogin.Controls.Add(lblNombUsuario);
            gbxLogin.Location = new Point(12, 12);
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Size = new Size(400, 213);
            gbxLogin.TabIndex = 0;
            gbxLogin.TabStop = false;
            gbxLogin.Text = "Inicio de sesion";
            // 
            // btnVerContraseña
            // 
            btnVerContraseña.Font = new Font("Segoe UI", 10F);
            btnVerContraseña.Location = new Point(301, 126);
            btnVerContraseña.Name = "btnVerContraseña";
            btnVerContraseña.Size = new Size(28, 27);
            btnVerContraseña.TabIndex = 4;
            btnVerContraseña.TabStop = false;
            btnVerContraseña.Text = "👁️";
            btnVerContraseña.UseVisualStyleBackColor = true;
            btnVerContraseña.Click += BtnVerContraseña_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(185, 128);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(110, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(95, 131);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(185, 61);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(110, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblNombUsuario
            // 
            lblNombUsuario.AutoSize = true;
            lblNombUsuario.Location = new Point(52, 64);
            lblNombUsuario.Name = "lblNombUsuario";
            lblNombUsuario.Size = new Size(113, 15);
            lblNombUsuario.TabIndex = 0;
            lblNombUsuario.Text = "Nombre de Usuario:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(177, 238);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 27);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Continuar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(341, 335);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(71, 27);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // lnkContraseña
            // 
            lnkContraseña.AutoSize = true;
            lnkContraseña.Location = new Point(22, 341);
            lnkContraseña.Name = "lnkContraseña";
            lnkContraseña.Size = new Size(119, 15);
            lnkContraseña.TabIndex = 3;
            lnkContraseña.TabStop = true;
            lnkContraseña.Text = "Olvide mi contraseña";
            lnkContraseña.Click += LnkContraseña_Click;
            // 
            // FrmInicioSesion
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(425, 374);
            Controls.Add(lnkContraseña);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(gbxLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInicioSesion";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesion Codeplay";
            Load += FrmInicioSesion_Load;
            gbxLogin.ResumeLayout(false);
            gbxLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxLogin;
        private Label lblNombUsuario;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Button btnVerContraseña;
        private Button btnLogin;
        private Button btnSalir;
        private LinkLabel lnkContraseña;
    }
}
