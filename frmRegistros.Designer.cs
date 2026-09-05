namespace Registro_de_ventas_Codeplay
{
    partial class frmRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistros));
            label1 = new Label();
            txtUsuario = new TextBox();
            grpRegistroEst = new GroupBox();
            cmbPais = new ComboBox();
            txtContrasenia = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtpFechaNac = new DateTimePicker();
            label3 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            btnRegistrar = new Button();
            btnSalir = new Button();
            dgvRegistros = new DataGridView();
            lblBienvenida = new Label();
            panel1 = new Panel();
            lblTitulo = new Label();
            lblDescripcion = new Label();
            lblDatos = new Label();
            grpRegistroEst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.RosyBrown;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(274, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(181, 27);
            txtUsuario.TabIndex = 1;
            // 
            // grpRegistroEst
            // 
            grpRegistroEst.BackColor = Color.Bisque;
            grpRegistroEst.Controls.Add(cmbPais);
            grpRegistroEst.Controls.Add(txtContrasenia);
            grpRegistroEst.Controls.Add(label5);
            grpRegistroEst.Controls.Add(label4);
            grpRegistroEst.Controls.Add(dtpFechaNac);
            grpRegistroEst.Controls.Add(label3);
            grpRegistroEst.Controls.Add(txtCorreo);
            grpRegistroEst.Controls.Add(label2);
            grpRegistroEst.Controls.Add(label1);
            grpRegistroEst.Controls.Add(txtUsuario);
            grpRegistroEst.ForeColor = Color.Maroon;
            grpRegistroEst.Location = new Point(12, 108);
            grpRegistroEst.Name = "grpRegistroEst";
            grpRegistroEst.Size = new Size(684, 339);
            grpRegistroEst.TabIndex = 2;
            grpRegistroEst.TabStop = false;
            grpRegistroEst.Text = "Crea tu cuenta de usuario";
            // 
            // cmbPais
            // 
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(274, 288);
            cmbPais.Margin = new Padding(3, 4, 3, 4);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(221, 28);
            cmbPais.TabIndex = 5;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.RosyBrown;
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Location = new Point(274, 101);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(181, 27);
            txtContrasenia.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 105);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 292);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 6;
            label4.Text = "Pais:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(274, 156);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(291, 27);
            dtpFechaNac.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 223);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 4;
            label3.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.RosyBrown;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(274, 216);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(241, 27);
            txtCorreo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 163);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Nacimiento:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(200, 479);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(364, 479);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvRegistros
            // 
            dgvRegistros.BackgroundColor = Color.LightCyan;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(722, 152);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(728, 295);
            dgvRegistros.TabIndex = 10;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(11, 573);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(19, 24);
            lblBienvenida.TabIndex = 11;
            lblBienvenida.Text = "a";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1439, 90);
            panel1.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(499, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(435, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de cuentas de usuario";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(542, 51);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(340, 23);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Gestor de cuentas de usuarios de Codeplay";
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDatos.Location = new Point(722, 117);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(141, 20);
            lblDatos.TabIndex = 2;
            lblDatos.Text = "Cuentas registradas:";
            // 
            // frmRegistros
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            CancelButton = btnSalir;
            ClientSize = new Size(1462, 605);
            Controls.Add(lblDatos);
            Controls.Add(panel1);
            Controls.Add(lblBienvenida);
            Controls.Add(dgvRegistros);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(grpRegistroEst);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistros";
            Text = "CODEPLAY: REGISTRO DE VENTA";
            Load += frmRegistros_Load;
            grpRegistroEst.ResumeLayout(false);
            grpRegistroEst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private GroupBox grpRegistroEst;
        private TextBox txtCorreo;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaNac;
        private Label label4;
        private Button btnRegistrar;
        private Button btnSalir;
        private DataGridView dgvRegistros;
        private TextBox txtContrasenia;
        private Label label5;
        private ComboBox cmbPais;
        private Label lblBienvenida;
        private Panel panel1;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblDatos;
    }
}