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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistros));
            dgvRegistros = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnSalir = new ReaLTaiizor.Controls.MaterialButton();
            btnRegistrar = new ReaLTaiizor.Controls.MaterialButton();
            grpRegistroEst = new ReaLTaiizor.Controls.MaterialCard();
            PicPais = new ReaLTaiizor.Controls.HopePictureBox();
            PicEmail = new ReaLTaiizor.Controls.HopePictureBox();
            PicFecha = new ReaLTaiizor.Controls.HopePictureBox();
            PicContrasena = new ReaLTaiizor.Controls.HopePictureBox();
            PicUsuario = new ReaLTaiizor.Controls.HopePictureBox();
            lblpais = new ReaLTaiizor.Controls.PoisonLabel();
            lblemail = new ReaLTaiizor.Controls.PoisonLabel();
            fechanac = new ReaLTaiizor.Controls.PoisonLabel();
            lblcontrasena = new ReaLTaiizor.Controls.PoisonLabel();
            cmbPais = new ReaLTaiizor.Controls.HopeComboBox();
            lblUsuario = new ReaLTaiizor.Controls.PoisonLabel();
            dtpFechaNac = new ReaLTaiizor.Controls.PoisonDateTime();
            txtCorreo = new ReaLTaiizor.Controls.SmallTextBox();
            txtContrasenia = new ReaLTaiizor.Controls.SmallTextBox();
            txtUsuario = new ReaLTaiizor.Controls.SmallTextBox();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            lblTitulo = new ReaLTaiizor.Controls.DungeonLabel();
            lblBienvenida = new ReaLTaiizor.Controls.DungeonLabel();
            PicManager = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            grpRegistroEst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicPais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicFecha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicContrasena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuario).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicManager).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToResizeRows = false;
            dgvRegistros.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvRegistros.BorderStyle = BorderStyle.None;
            dgvRegistros.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRegistros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvRegistros.GridColor = Color.FromArgb(255, 255, 255);
            dgvRegistros.Location = new Point(376, 67);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRegistros.ScrollBars = ScrollBars.None;
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.Size = new Size(787, 390);
            dgvRegistros.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalir.Depth = 0;
            btnSalir.HighEmphasis = true;
            btnSalir.Icon = null;
            btnSalir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalir.Location = new Point(239, 449);
            btnSalir.Margin = new Padding(4, 6, 4, 6);
            btnSalir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalir.Name = "btnSalir";
            btnSalir.NoAccentTextColor = Color.Empty;
            btnSalir.Size = new Size(84, 45);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "&Salir";
            btnSalir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalir.UseAccentColor = false;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistrar.Depth = 0;
            btnRegistrar.HighEmphasis = true;
            btnRegistrar.Icon = null;
            btnRegistrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRegistrar.Location = new Point(34, 449);
            btnRegistrar.Margin = new Padding(4, 6, 4, 6);
            btnRegistrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.NoAccentTextColor = Color.Empty;
            btnRegistrar.Size = new Size(131, 45);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistrar.UseAccentColor = false;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // grpRegistroEst
            // 
            grpRegistroEst.BackColor = Color.FromArgb(255, 255, 255);
            grpRegistroEst.Controls.Add(PicPais);
            grpRegistroEst.Controls.Add(PicEmail);
            grpRegistroEst.Controls.Add(PicFecha);
            grpRegistroEst.Controls.Add(PicContrasena);
            grpRegistroEst.Controls.Add(PicUsuario);
            grpRegistroEst.Controls.Add(lblpais);
            grpRegistroEst.Controls.Add(lblemail);
            grpRegistroEst.Controls.Add(btnSalir);
            grpRegistroEst.Controls.Add(btnRegistrar);
            grpRegistroEst.Controls.Add(fechanac);
            grpRegistroEst.Controls.Add(lblcontrasena);
            grpRegistroEst.Controls.Add(cmbPais);
            grpRegistroEst.Controls.Add(lblUsuario);
            grpRegistroEst.Controls.Add(dtpFechaNac);
            grpRegistroEst.Controls.Add(txtCorreo);
            grpRegistroEst.Controls.Add(txtContrasenia);
            grpRegistroEst.Controls.Add(txtUsuario);
            grpRegistroEst.Depth = 0;
            grpRegistroEst.ForeColor = Color.FromArgb(222, 0, 0, 0);
            grpRegistroEst.Location = new Point(0, 65);
            grpRegistroEst.Margin = new Padding(17);
            grpRegistroEst.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            grpRegistroEst.Name = "grpRegistroEst";
            grpRegistroEst.Padding = new Padding(17);
            grpRegistroEst.Size = new Size(376, 516);
            grpRegistroEst.TabIndex = 9;
            // 
            // PicPais
            // 
            PicPais.BackColor = Color.FromArgb(192, 196, 204);
            PicPais.Image = Properties.Resources.country_direction_location_map_navigation_pin_svgrepo_com;
            PicPais.Location = new Point(266, 372);
            PicPais.Name = "PicPais";
            PicPais.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PicPais.Size = new Size(90, 42);
            PicPais.SizeMode = PictureBoxSizeMode.Zoom;
            PicPais.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            PicPais.TabIndex = 19;
            PicPais.TabStop = false;
            PicPais.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // PicEmail
            // 
            PicEmail.BackColor = Color.FromArgb(192, 196, 204);
            PicEmail.Image = Properties.Resources.email_message_svgrepo_com;
            PicEmail.Location = new Point(266, 283);
            PicEmail.Name = "PicEmail";
            PicEmail.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PicEmail.Size = new Size(90, 56);
            PicEmail.SizeMode = PictureBoxSizeMode.Zoom;
            PicEmail.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            PicEmail.TabIndex = 18;
            PicEmail.TabStop = false;
            PicEmail.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // PicFecha
            // 
            PicFecha.BackColor = Color.FromArgb(192, 196, 204);
            PicFecha.Image = Properties.Resources.calendar_svgrepo_com;
            PicFecha.Location = new Point(266, 213);
            PicFecha.Name = "PicFecha";
            PicFecha.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PicFecha.Size = new Size(90, 42);
            PicFecha.SizeMode = PictureBoxSizeMode.Zoom;
            PicFecha.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            PicFecha.TabIndex = 17;
            PicFecha.TabStop = false;
            PicFecha.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // PicContrasena
            // 
            PicContrasena.BackColor = Color.FromArgb(192, 196, 204);
            PicContrasena.Image = Properties.Resources.password_management_svgrepo_com;
            PicContrasena.Location = new Point(266, 116);
            PicContrasena.Name = "PicContrasena";
            PicContrasena.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PicContrasena.Size = new Size(90, 54);
            PicContrasena.SizeMode = PictureBoxSizeMode.Zoom;
            PicContrasena.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            PicContrasena.TabIndex = 16;
            PicContrasena.TabStop = false;
            PicContrasena.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // PicUsuario
            // 
            PicUsuario.BackColor = Color.FromArgb(192, 196, 204);
            PicUsuario.Image = Properties.Resources.user_circle_svgrepo_com__1_;
            PicUsuario.Location = new Point(266, 44);
            PicUsuario.Name = "PicUsuario";
            PicUsuario.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PicUsuario.Size = new Size(90, 42);
            PicUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            PicUsuario.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            PicUsuario.TabIndex = 15;
            PicUsuario.TabStop = false;
            PicUsuario.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblpais
            // 
            lblpais.AutoSize = true;
            lblpais.Location = new Point(34, 355);
            lblpais.Name = "lblpais";
            lblpais.Size = new Size(34, 20);
            lblpais.TabIndex = 11;
            lblpais.Text = "PAÍS";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(34, 280);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(48, 20);
            lblemail.TabIndex = 10;
            lblemail.Text = "EMAIL";
            // 
            // fechanac
            // 
            fechanac.AutoSize = true;
            fechanac.Location = new Point(34, 190);
            fechanac.Name = "fechanac";
            fechanac.Size = new Size(162, 20);
            fechanac.TabIndex = 9;
            fechanac.Text = "FECHA DE NACIMIENTO";
            // 
            // lblcontrasena
            // 
            lblcontrasena.AutoSize = true;
            lblcontrasena.Location = new Point(34, 105);
            lblcontrasena.Name = "lblcontrasena";
            lblcontrasena.Size = new Size(100, 20);
            lblcontrasena.TabIndex = 8;
            lblcontrasena.Text = "CONTRASEÑA";
            // 
            // cmbPais
            // 
            cmbPais.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPais.FlatStyle = FlatStyle.Flat;
            cmbPais.Font = new Font("Segoe UI", 12F);
            cmbPais.FormattingEnabled = true;
            cmbPais.ItemHeight = 30;
            cmbPais.Location = new Point(34, 378);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(226, 36);
            cmbPais.TabIndex = 7;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(34, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "USUARIO";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpFechaNac.Location = new Point(34, 223);
            dtpFechaNac.MinimumSize = new Size(0, 30);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(226, 30);
            dtpFechaNac.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Transparent;
            txtCorreo.BorderColor = Color.FromArgb(180, 180, 180);
            txtCorreo.CustomBGColor = Color.White;
            txtCorreo.Font = new Font("Tahoma", 11F);
            txtCorreo.ForeColor = Color.DimGray;
            txtCorreo.Location = new Point(34, 303);
            txtCorreo.MaxLength = 32767;
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = false;
            txtCorreo.Size = new Size(226, 33);
            txtCorreo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtCorreo.TabIndex = 3;
            txtCorreo.TextAlignment = HorizontalAlignment.Left;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.Transparent;
            txtContrasenia.BorderColor = Color.FromArgb(180, 180, 180);
            txtContrasenia.CustomBGColor = Color.White;
            txtContrasenia.Font = new Font("Tahoma", 11F);
            txtContrasenia.ForeColor = Color.DimGray;
            txtContrasenia.Location = new Point(34, 137);
            txtContrasenia.MaxLength = 32767;
            txtContrasenia.Multiline = false;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.ReadOnly = false;
            txtContrasenia.Size = new Size(226, 33);
            txtContrasenia.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtContrasenia.TabIndex = 2;
            txtContrasenia.TextAlignment = HorizontalAlignment.Left;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.BorderColor = Color.FromArgb(180, 180, 180);
            txtUsuario.CustomBGColor = Color.White;
            txtUsuario.Font = new Font("Tahoma", 11F);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(34, 53);
            txtUsuario.MaxLength = 32767;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = false;
            txtUsuario.Size = new Size(226, 33);
            txtUsuario.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtUsuario.TabIndex = 1;
            txtUsuario.TextAlignment = HorizontalAlignment.Left;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(hopePictureBox1);
            materialCard1.Controls.Add(lblTitulo);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(17);
            materialCard1.MaximumSize = new Size(0, 65);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(17);
            materialCard1.Size = new Size(1163, 65);
            materialCard1.TabIndex = 2;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Properties.Resources.isky_victory;
            hopePictureBox1.Location = new Point(118, 0);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(133, 65);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 20;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 11F);
            lblTitulo.ForeColor = Color.FromArgb(76, 76, 77);
            lblTitulo.Location = new Point(386, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(323, 25);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "REGISTRO DE USUARIOS | CODEPLAY";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 11F);
            lblBienvenida.ForeColor = Color.FromArgb(76, 76, 77);
            lblBienvenida.Location = new Point(988, 560);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(105, 25);
            lblBienvenida.TabIndex = 13;
            lblBienvenida.Text = "MANAGER:\r\n";
            // 
            // PicManager
            // 
            PicManager.BackColor = Color.FromArgb(245, 247, 250);
            PicManager.ForeColor = SystemColors.ControlText;
            PicManager.IconChar = FontAwesome.Sharp.IconChar.GithubSquare;
            PicManager.IconColor = SystemColors.ControlText;
            PicManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PicManager.IconSize = 40;
            PicManager.Location = new Point(949, 555);
            PicManager.Name = "PicManager";
            PicManager.Size = new Size(40, 40);
            PicManager.TabIndex = 14;
            PicManager.TabStop = false;
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1163, 588);
            Controls.Add(PicManager);
            Controls.Add(lblBienvenida);
            Controls.Add(materialCard1);
            Controls.Add(grpRegistroEst);
            Controls.Add(dgvRegistros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistros";
            Text = "! BIENVENIDO !";
            Load += frmRegistros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            grpRegistroEst.ResumeLayout(false);
            grpRegistroEst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicPais).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicFecha).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicContrasena).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuario).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.PoisonDataGridView dgvRegistros;
        private ReaLTaiizor.Controls.MaterialButton btnSalir;
        private ReaLTaiizor.Controls.MaterialButton btnRegistrar;
        private ReaLTaiizor.Controls.MaterialCard grpRegistroEst;
        private ReaLTaiizor.Controls.PoisonLabel lblUsuario;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaNac;
        private ReaLTaiizor.Controls.SmallTextBox txtUsuario;
        private ReaLTaiizor.Controls.SmallTextBox txtContrasenia;
        private ReaLTaiizor.Controls.SmallTextBox txtCorreo;
        private ReaLTaiizor.Controls.PoisonLabel lblemail;
        private ReaLTaiizor.Controls.PoisonLabel fechanac;
        private ReaLTaiizor.Controls.PoisonLabel lblcontrasena;
        private ReaLTaiizor.Controls.HopeComboBox cmbPais;
        private ReaLTaiizor.Controls.PoisonLabel lblpais;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.DungeonLabel lblTitulo;
        private ReaLTaiizor.Controls.DungeonLabel lblBienvenida;
        private ReaLTaiizor.Controls.HopePictureBox PicUsuario;
        private ReaLTaiizor.Controls.HopePictureBox PicFecha;
        private ReaLTaiizor.Controls.HopePictureBox PicContrasena;
        private ReaLTaiizor.Controls.HopePictureBox PicPais;
        private ReaLTaiizor.Controls.HopePictureBox PicEmail;
        private FontAwesome.Sharp.IconPictureBox PicManager;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}