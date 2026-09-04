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
            grpRegistroEst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 33);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(240, 28);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(159, 23);
            txtUsuario.TabIndex = 1;
            // 
            // grpRegistroEst
            // 
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
            grpRegistroEst.Location = new Point(10, 9);
            grpRegistroEst.Margin = new Padding(3, 2, 3, 2);
            grpRegistroEst.Name = "grpRegistroEst";
            grpRegistroEst.Padding = new Padding(3, 2, 3, 2);
            grpRegistroEst.Size = new Size(552, 254);
            grpRegistroEst.TabIndex = 2;
            grpRegistroEst.TabStop = false;
            grpRegistroEst.Text = "Crea tu cuenta de usuario";
            // 
            // cmbPais
            // 
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(240, 216);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(194, 23);
            cmbPais.TabIndex = 10;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(240, 76);
            txtContrasenia.Margin = new Padding(3, 2, 3, 2);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(159, 23);
            txtContrasenia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 79);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 219);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Pais:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(240, 117);
            dtpFechaNac.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(255, 23);
            dtpFechaNac.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 167);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(240, 162);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(211, 23);
            txtCorreo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 122);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Nacimiento:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(10, 287);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 22);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(116, 287);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 22);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvRegistros
            // 
            dgvRegistros.BackgroundColor = Color.Gainsboro;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Dock = DockStyle.Right;
            dgvRegistros.Location = new Point(636, 0);
            dgvRegistros.Margin = new Padding(3, 2, 3, 2);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(373, 454);
            dgvRegistros.TabIndex = 10;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(10, 430);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(16, 20);
            lblBienvenida.TabIndex = 11;
            lblBienvenida.Text = "a";
            // 
            // frmRegistros
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(1009, 454);
            Controls.Add(lblBienvenida);
            Controls.Add(dgvRegistros);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(grpRegistroEst);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegistros";
            Text = "CODEPLAY: REGISTRO DE VENTA";
            Load += frmRegistros_Load;
            grpRegistroEst.ResumeLayout(false);
            grpRegistroEst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
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
    }
}