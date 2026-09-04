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
            label1 = new Label();
            txtUsuario = new TextBox();
            grpRegistroEst = new GroupBox();
            txtContrasenia = new TextBox();
            label5 = new Label();
            txtPais = new TextBox();
            label4 = new Label();
            dtpFechaNac = new DateTimePicker();
            label3 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            btnRegistrar = new Button();
            btnSalir = new Button();
            dgvRegistros = new DataGridView();
            grpRegistroEst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
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
            txtUsuario.Location = new Point(274, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 1;
            // 
            // grpRegistroEst
            // 
            grpRegistroEst.Controls.Add(txtContrasenia);
            grpRegistroEst.Controls.Add(label5);
            grpRegistroEst.Controls.Add(txtPais);
            grpRegistroEst.Controls.Add(label4);
            grpRegistroEst.Controls.Add(dtpFechaNac);
            grpRegistroEst.Controls.Add(label3);
            grpRegistroEst.Controls.Add(txtCorreo);
            grpRegistroEst.Controls.Add(label2);
            grpRegistroEst.Controls.Add(label1);
            grpRegistroEst.Controls.Add(txtUsuario);
            grpRegistroEst.Location = new Point(12, 12);
            grpRegistroEst.Name = "grpRegistroEst";
            grpRegistroEst.Size = new Size(631, 339);
            grpRegistroEst.TabIndex = 2;
            grpRegistroEst.TabStop = false;
            grpRegistroEst.Text = "Crea tu cuenta ";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(274, 102);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(125, 27);
            txtContrasenia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 109);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(274, 285);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(125, 27);
            txtPais.TabIndex = 7;
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
            dtpFechaNac.TabIndex = 5;
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
            txtCorreo.Location = new Point(274, 216);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 3;
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
            btnRegistrar.Location = new Point(12, 383);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(133, 383);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
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
            dgvRegistros.Location = new Point(727, 0);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(426, 606);
            dgvRegistros.TabIndex = 10;
            // 
            // frmRegistros
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(1153, 606);
            Controls.Add(dgvRegistros);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(grpRegistroEst);
            Name = "frmRegistros";
            Text = "CODEPLAY: REGISTRO DE VENTA";
            Load += frmRegistros_Load;
            grpRegistroEst.ResumeLayout(false);
            grpRegistroEst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private GroupBox grpRegistroEst;
        private TextBox txtCorreo;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaNac;
        private TextBox txtPais;
        private Label label4;
        private Button btnRegistrar;
        private Button btnSalir;
        private DataGridView dgvRegistros;
        private TextBox txtContrasenia;
        private Label label5;
    }
}