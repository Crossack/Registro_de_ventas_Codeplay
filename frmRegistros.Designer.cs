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
            label1.ForeColor = Color.FromArgb(224, 230, 237);
            label1.Location = new Point(7, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Location = new Point(343, 47);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(225, 31);
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
            grpRegistroEst.ForeColor = Color.FromArgb(224, 230, 237);
            grpRegistroEst.Location = new Point(14, 15);
            grpRegistroEst.Margin = new Padding(4, 3, 4, 3);
            grpRegistroEst.Name = "grpRegistroEst";
            grpRegistroEst.Padding = new Padding(4, 3, 4, 3);
            grpRegistroEst.Size = new Size(789, 423);
            grpRegistroEst.TabIndex = 2;
            grpRegistroEst.TabStop = false;
            grpRegistroEst.Text = "Crea tu cuenta de usuario";
            // 
            // cmbPais
            // 
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(343, 360);
            cmbPais.Margin = new Padding(4, 5, 4, 5);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(275, 33);
            cmbPais.TabIndex = 10;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = SystemColors.Window;
            txtContrasenia.Location = new Point(343, 127);
            txtContrasenia.Margin = new Padding(4, 3, 4, 3);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(225, 31);
            txtContrasenia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(224, 230, 237);
            label5.Location = new Point(9, 132);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(224, 230, 237);
            label4.Location = new Point(7, 365);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 6;
            label4.Text = "Pais:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.CalendarForeColor = SystemColors.MenuHighlight;
            dtpFechaNac.CalendarMonthBackground = SystemColors.MenuHighlight;
            dtpFechaNac.CalendarTitleBackColor = SystemColors.MenuHighlight;
            dtpFechaNac.CalendarTitleForeColor = SystemColors.MenuHighlight;
            dtpFechaNac.CalendarTrailingForeColor = SystemColors.MenuHighlight;
            dtpFechaNac.Location = new Point(343, 195);
            dtpFechaNac.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(363, 31);
            dtpFechaNac.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(224, 230, 237);
            label3.Location = new Point(7, 278);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 4;
            label3.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(343, 270);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(300, 31);
            txtCorreo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 230, 237);
            label2.Location = new Point(7, 203);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Nacimiento:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(38, 166, 154);
            btnRegistrar.ForeColor = Color.FromArgb(224, 230, 237);
            btnRegistrar.Location = new Point(14, 478);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(117, 37);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Teal;
            btnSalir.ForeColor = Color.FromArgb(224, 230, 237);
            btnSalir.Location = new Point(166, 478);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 37);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvRegistros
            // 
            dgvRegistros.BackgroundColor = Color.FromArgb(81, 113, 130);
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Dock = DockStyle.Right;
            dgvRegistros.Location = new Point(908, 0);
            dgvRegistros.Margin = new Padding(4, 3, 4, 3);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(533, 757);
            dgvRegistros.TabIndex = 10;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(14, 717);
            lblBienvenida.Margin = new Padding(4, 0, 4, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(24, 29);
            lblBienvenida.TabIndex = 11;
            lblBienvenida.Text = "a";
            // 
            // frmRegistros
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            CancelButton = btnSalir;
            ClientSize = new Size(1441, 757);
            Controls.Add(lblBienvenida);
            Controls.Add(dgvRegistros);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(grpRegistroEst);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
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