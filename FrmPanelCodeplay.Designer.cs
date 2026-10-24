namespace Registro_de_ventas_Codeplay
{
    partial class FrmPanelCodeplay
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
            pnlMenuOpciones = new Panel();
            btnGenerarReporte = new Button();
            btnOpcionEstadistica = new Button();
            pnlSubMenuReportes = new Panel();
            btnSubReportesRevision = new Button();
            btnSubReportados = new Button();
            btnSubSuspendidos = new Button();
            btnSalir = new Button();
            btnOpcionReportes = new Button();
            btnOpcionListaUsuarios = new Button();
            btnMenuRegistrar = new Button();
            lblBienvenida = new Label();
            pnlMenuEstadisticas = new Panel();
            btnEstadisticaTest = new Button();
            pnlMenuListaUsuario = new Panel();
            pnlSubListaUsuariosOpciones = new Panel();
            btnListaBanear = new Button();
            btnListaEliminar = new Button();
            btnListaReportar = new Button();
            dgvListaUsuarios = new DataGridView();
            grpMasterMenu = new GroupBox();
            pnlMenuOpciones.SuspendLayout();
            pnlSubMenuReportes.SuspendLayout();
            pnlMenuEstadisticas.SuspendLayout();
            pnlMenuListaUsuario.SuspendLayout();
            pnlSubListaUsuariosOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            grpMasterMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuOpciones
            // 
            pnlMenuOpciones.Controls.Add(btnGenerarReporte);
            pnlMenuOpciones.Controls.Add(btnOpcionEstadistica);
            pnlMenuOpciones.Controls.Add(pnlSubMenuReportes);
            pnlMenuOpciones.Controls.Add(btnSalir);
            pnlMenuOpciones.Controls.Add(btnOpcionReportes);
            pnlMenuOpciones.Controls.Add(btnOpcionListaUsuarios);
            pnlMenuOpciones.Controls.Add(btnMenuRegistrar);
            pnlMenuOpciones.Location = new Point(12, 12);
            pnlMenuOpciones.Name = "pnlMenuOpciones";
            pnlMenuOpciones.Size = new Size(139, 452);
            pnlMenuOpciones.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Dock = DockStyle.Top;
            btnGenerarReporte.Location = new Point(0, 190);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(139, 27);
            btnGenerarReporte.TabIndex = 5;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // btnOpcionEstadistica
            // 
            btnOpcionEstadistica.Dock = DockStyle.Top;
            btnOpcionEstadistica.Location = new Point(0, 163);
            btnOpcionEstadistica.Name = "btnOpcionEstadistica";
            btnOpcionEstadistica.Size = new Size(139, 27);
            btnOpcionEstadistica.TabIndex = 4;
            btnOpcionEstadistica.Text = "Estadisticas";
            btnOpcionEstadistica.UseVisualStyleBackColor = true;
            btnOpcionEstadistica.Click += BtnOpcionEstadistica_Click;
            // 
            // pnlSubMenuReportes
            // 
            pnlSubMenuReportes.Controls.Add(btnSubReportesRevision);
            pnlSubMenuReportes.Controls.Add(btnSubReportados);
            pnlSubMenuReportes.Controls.Add(btnSubSuspendidos);
            pnlSubMenuReportes.Dock = DockStyle.Top;
            pnlSubMenuReportes.Location = new Point(0, 81);
            pnlSubMenuReportes.Name = "pnlSubMenuReportes";
            pnlSubMenuReportes.Size = new Size(139, 82);
            pnlSubMenuReportes.TabIndex = 1;
            pnlSubMenuReportes.Visible = false;
            // 
            // btnSubReportesRevision
            // 
            btnSubReportesRevision.Dock = DockStyle.Top;
            btnSubReportesRevision.Location = new Point(0, 54);
            btnSubReportesRevision.Name = "btnSubReportesRevision";
            btnSubReportesRevision.Size = new Size(139, 27);
            btnSubReportesRevision.TabIndex = 9;
            btnSubReportesRevision.Text = "Reportes en Revision";
            btnSubReportesRevision.UseVisualStyleBackColor = true;
            // 
            // btnSubReportados
            // 
            btnSubReportados.Dock = DockStyle.Top;
            btnSubReportados.Location = new Point(0, 27);
            btnSubReportados.Name = "btnSubReportados";
            btnSubReportados.Size = new Size(139, 27);
            btnSubReportados.TabIndex = 8;
            btnSubReportados.Text = "Usuarios Reportados";
            btnSubReportados.UseVisualStyleBackColor = true;
            // 
            // btnSubSuspendidos
            // 
            btnSubSuspendidos.Dock = DockStyle.Top;
            btnSubSuspendidos.Location = new Point(0, 0);
            btnSubSuspendidos.Name = "btnSubSuspendidos";
            btnSubSuspendidos.Size = new Size(139, 27);
            btnSubSuspendidos.TabIndex = 7;
            btnSubSuspendidos.Text = "Usuarios Supendidos";
            btnSubSuspendidos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.Location = new Point(0, 425);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 27);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Log Out";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // btnOpcionReportes
            // 
            btnOpcionReportes.Dock = DockStyle.Top;
            btnOpcionReportes.Location = new Point(0, 54);
            btnOpcionReportes.Name = "btnOpcionReportes";
            btnOpcionReportes.Size = new Size(139, 27);
            btnOpcionReportes.TabIndex = 3;
            btnOpcionReportes.Text = "Reportes";
            btnOpcionReportes.UseVisualStyleBackColor = true;
            btnOpcionReportes.Click += BtnOpcionReportes_Click;
            // 
            // btnOpcionListaUsuarios
            // 
            btnOpcionListaUsuarios.Dock = DockStyle.Top;
            btnOpcionListaUsuarios.Location = new Point(0, 27);
            btnOpcionListaUsuarios.Name = "btnOpcionListaUsuarios";
            btnOpcionListaUsuarios.Size = new Size(139, 27);
            btnOpcionListaUsuarios.TabIndex = 2;
            btnOpcionListaUsuarios.Text = "Lista de Usuarios";
            btnOpcionListaUsuarios.UseVisualStyleBackColor = true;
            btnOpcionListaUsuarios.Click += BtnOpcionListaUsuario_Click;
            // 
            // btnMenuRegistrar
            // 
            btnMenuRegistrar.Dock = DockStyle.Top;
            btnMenuRegistrar.Location = new Point(0, 0);
            btnMenuRegistrar.Name = "btnMenuRegistrar";
            btnMenuRegistrar.Size = new Size(139, 27);
            btnMenuRegistrar.TabIndex = 1;
            btnMenuRegistrar.Text = "Registrar Usuarios";
            btnMenuRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Silver;
            lblBienvenida.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenida.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = SystemColors.ControlText;
            lblBienvenida.Location = new Point(325, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(184, 39);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Hola User, Rol";
            // 
            // pnlMenuEstadisticas
            // 
            pnlMenuEstadisticas.Controls.Add(btnEstadisticaTest);
            pnlMenuEstadisticas.Dock = DockStyle.Top;
            pnlMenuEstadisticas.Location = new Point(3, 309);
            pnlMenuEstadisticas.Name = "pnlMenuEstadisticas";
            pnlMenuEstadisticas.Size = new Size(687, 58);
            pnlMenuEstadisticas.TabIndex = 1;
            pnlMenuEstadisticas.Visible = false;
            // 
            // btnEstadisticaTest
            // 
            btnEstadisticaTest.Dock = DockStyle.Fill;
            btnEstadisticaTest.Font = new Font("Wingdings", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnEstadisticaTest.Location = new Point(0, 0);
            btnEstadisticaTest.Name = "btnEstadisticaTest";
            btnEstadisticaTest.Size = new Size(687, 58);
            btnEstadisticaTest.TabIndex = 0;
            btnEstadisticaTest.Text = "Hola Mundo!";
            btnEstadisticaTest.UseVisualStyleBackColor = true;
            // 
            // pnlMenuListaUsuario
            // 
            pnlMenuListaUsuario.Controls.Add(pnlSubListaUsuariosOpciones);
            pnlMenuListaUsuario.Controls.Add(dgvListaUsuarios);
            pnlMenuListaUsuario.Dock = DockStyle.Top;
            pnlMenuListaUsuario.Location = new Point(3, 19);
            pnlMenuListaUsuario.Name = "pnlMenuListaUsuario";
            pnlMenuListaUsuario.Size = new Size(687, 290);
            pnlMenuListaUsuario.TabIndex = 0;
            // 
            // pnlSubListaUsuariosOpciones
            // 
            pnlSubListaUsuariosOpciones.Controls.Add(btnListaBanear);
            pnlSubListaUsuariosOpciones.Controls.Add(btnListaEliminar);
            pnlSubListaUsuariosOpciones.Controls.Add(btnListaReportar);
            pnlSubListaUsuariosOpciones.Dock = DockStyle.Top;
            pnlSubListaUsuariosOpciones.Location = new Point(0, 218);
            pnlSubListaUsuariosOpciones.Name = "pnlSubListaUsuariosOpciones";
            pnlSubListaUsuariosOpciones.Size = new Size(687, 62);
            pnlSubListaUsuariosOpciones.TabIndex = 1;
            // 
            // btnListaBanear
            // 
            btnListaBanear.Location = new Point(540, 21);
            btnListaBanear.Name = "btnListaBanear";
            btnListaBanear.Size = new Size(75, 23);
            btnListaBanear.TabIndex = 2;
            btnListaBanear.Text = "Banear";
            btnListaBanear.UseVisualStyleBackColor = true;
            // 
            // btnListaEliminar
            // 
            btnListaEliminar.Location = new Point(304, 20);
            btnListaEliminar.Name = "btnListaEliminar";
            btnListaEliminar.Size = new Size(75, 23);
            btnListaEliminar.TabIndex = 1;
            btnListaEliminar.Text = "Eliminar";
            btnListaEliminar.UseVisualStyleBackColor = true;
            // 
            // btnListaReportar
            // 
            btnListaReportar.Location = new Point(58, 21);
            btnListaReportar.Name = "btnListaReportar";
            btnListaReportar.Size = new Size(75, 23);
            btnListaReportar.TabIndex = 0;
            btnListaReportar.Text = "Reportar";
            btnListaReportar.UseVisualStyleBackColor = true;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuarios.Dock = DockStyle.Top;
            dgvListaUsuarios.Location = new Point(0, 0);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.Size = new Size(687, 218);
            dgvListaUsuarios.TabIndex = 0;
            // 
            // grpMasterMenu
            // 
            grpMasterMenu.Controls.Add(pnlMenuEstadisticas);
            grpMasterMenu.Controls.Add(pnlMenuListaUsuario);
            grpMasterMenu.Location = new Point(157, 51);
            grpMasterMenu.Name = "grpMasterMenu";
            grpMasterMenu.Size = new Size(693, 413);
            grpMasterMenu.TabIndex = 4;
            grpMasterMenu.TabStop = false;
            // 
            // FrmPanelCodeplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 469);
            Controls.Add(grpMasterMenu);
            Controls.Add(lblBienvenida);
            Controls.Add(pnlMenuOpciones);
            Name = "FrmPanelCodeplay";
            Text = "FrmPanelCodeplay";
            Load += FrmPanelCodeplay_Load;
            pnlMenuOpciones.ResumeLayout(false);
            pnlSubMenuReportes.ResumeLayout(false);
            pnlMenuEstadisticas.ResumeLayout(false);
            pnlMenuListaUsuario.ResumeLayout(false);
            pnlSubListaUsuariosOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            grpMasterMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenuOpciones;
        private Button btnOpcionListaUsuarios;
        private Button btnMenuRegistrar;
        private Button btnOpcionEstadistica;
        private Button btnOpcionReportes;
        private Button btnSalir;
        private Button btnGenerarReporte;
        private Panel pnlSubMenuReportes;
        private Button btnSubSuspendidos;
        private Button btnSubReportados;
        private Button btnSubReportesRevision;
        private Label lblBienvenida;
        private Panel pnlMenuListaUsuario;
        private DataGridView dgvListaUsuarios;
        private Panel pnlSubListaUsuariosOpciones;
        private Button btnListaBanear;
        private Button btnListaEliminar;
        private Button btnListaReportar;
        private Panel pnlMenuEstadisticas;
        private Button btnEstadisticaTest;
        private GroupBox grpMasterMenu;
    }
}