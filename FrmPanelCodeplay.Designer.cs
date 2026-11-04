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
            pnlMenuGenerarReporte = new Panel();
            btnGenerarReporte = new ReaLTaiizor.Controls.MaterialButton();
            lblFechaReporteFinal = new ReaLTaiizor.Controls.DungeonLabel();
            lblFechaReporteInicio = new ReaLTaiizor.Controls.DungeonLabel();
            lblReporteTitulo = new ReaLTaiizor.Controls.DungeonLabel();
            dtpFechaReporteFinal = new ReaLTaiizor.Controls.PoisonDateTime();
            dtpFechaReporteInicio = new ReaLTaiizor.Controls.PoisonDateTime();
            pnlMasterMenu = new ReaLTaiizor.Controls.MaterialCard();
            mbtnGenerarReporte = new ReaLTaiizor.Controls.MaterialButton();
            mbtnEstadisticas = new ReaLTaiizor.Controls.MaterialButton();
            pnlSubMenuReportes = new ReaLTaiizor.Controls.MaterialCard();
            mbtnReportesRevision = new ReaLTaiizor.Controls.MaterialButton();
            mbtnSuspendidos = new ReaLTaiizor.Controls.MaterialButton();
            mbtnReportados = new ReaLTaiizor.Controls.MaterialButton();
            mbtnMenuReportes = new ReaLTaiizor.Controls.MaterialButton();
            mbtnSalir = new ReaLTaiizor.Controls.MaterialButton();
            mbtnRegistroUsuarios = new ReaLTaiizor.Controls.MaterialButton();
            mbtnListaUsuarios = new ReaLTaiizor.Controls.MaterialButton();
            pnlMenuEstadisticas.SuspendLayout();
            pnlMenuListaUsuario.SuspendLayout();
            pnlSubListaUsuariosOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            grpMasterMenu.SuspendLayout();
            pnlMenuGenerarReporte.SuspendLayout();
            pnlMasterMenu.SuspendLayout();
            pnlSubMenuReportes.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Silver;
            lblBienvenida.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenida.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = SystemColors.ControlText;
            lblBienvenida.Location = new Point(423, 14);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(184, 39);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Hola User, Rol";
            // 
            // pnlMenuEstadisticas
            // 
            pnlMenuEstadisticas.Controls.Add(btnEstadisticaTest);
            pnlMenuEstadisticas.Dock = DockStyle.Top;
            pnlMenuEstadisticas.Location = new Point(3, 127);
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
            pnlMenuListaUsuario.Size = new Size(687, 108);
            pnlMenuListaUsuario.TabIndex = 0;
            // 
            // pnlSubListaUsuariosOpciones
            // 
            pnlSubListaUsuariosOpciones.Controls.Add(btnListaBanear);
            pnlSubListaUsuariosOpciones.Controls.Add(btnListaEliminar);
            pnlSubListaUsuariosOpciones.Controls.Add(btnListaReportar);
            pnlSubListaUsuariosOpciones.Dock = DockStyle.Top;
            pnlSubListaUsuariosOpciones.Location = new Point(0, 277);
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
            dgvListaUsuarios.RowHeadersWidth = 51;
            dgvListaUsuarios.Size = new Size(687, 277);
            dgvListaUsuarios.TabIndex = 0;
            // 
            // grpMasterMenu
            // 
            grpMasterMenu.Controls.Add(pnlMenuGenerarReporte);
            grpMasterMenu.Controls.Add(pnlMenuEstadisticas);
            grpMasterMenu.Controls.Add(pnlMenuListaUsuario);
            grpMasterMenu.Location = new Point(308, 57);
            grpMasterMenu.Name = "grpMasterMenu";
            grpMasterMenu.Size = new Size(693, 413);
            grpMasterMenu.TabIndex = 4;
            grpMasterMenu.TabStop = false;
            // 
            // pnlMenuGenerarReporte
            // 
            pnlMenuGenerarReporte.Controls.Add(btnGenerarReporte);
            pnlMenuGenerarReporte.Controls.Add(lblFechaReporteFinal);
            pnlMenuGenerarReporte.Controls.Add(lblFechaReporteInicio);
            pnlMenuGenerarReporte.Controls.Add(lblReporteTitulo);
            pnlMenuGenerarReporte.Controls.Add(dtpFechaReporteFinal);
            pnlMenuGenerarReporte.Controls.Add(dtpFechaReporteInicio);
            pnlMenuGenerarReporte.Dock = DockStyle.Top;
            pnlMenuGenerarReporte.Location = new Point(3, 185);
            pnlMenuGenerarReporte.Name = "pnlMenuGenerarReporte";
            pnlMenuGenerarReporte.Size = new Size(687, 76);
            pnlMenuGenerarReporte.TabIndex = 6;
            pnlMenuGenerarReporte.Visible = false;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerarReporte.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGenerarReporte.Depth = 0;
            btnGenerarReporte.HighEmphasis = true;
            btnGenerarReporte.Icon = null;
            btnGenerarReporte.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGenerarReporte.Location = new Point(281, 234);
            btnGenerarReporte.Margin = new Padding(4, 6, 4, 6);
            btnGenerarReporte.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.NoAccentTextColor = Color.Empty;
            btnGenerarReporte.Size = new Size(154, 36);
            btnGenerarReporte.TabIndex = 5;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGenerarReporte.UseAccentColor = false;
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += BtnGenerarReporte_Click;
            // 
            // lblFechaReporteFinal
            // 
            lblFechaReporteFinal.AutoSize = true;
            lblFechaReporteFinal.BackColor = Color.Transparent;
            lblFechaReporteFinal.Font = new Font("Segoe UI", 11F);
            lblFechaReporteFinal.ForeColor = Color.FromArgb(76, 76, 77);
            lblFechaReporteFinal.Location = new Point(415, 115);
            lblFechaReporteFinal.Name = "lblFechaReporteFinal";
            lblFechaReporteFinal.Size = new Size(47, 20);
            lblFechaReporteFinal.TabIndex = 4;
            lblFechaReporteFinal.Text = "Hasta";
            // 
            // lblFechaReporteInicio
            // 
            lblFechaReporteInicio.AutoSize = true;
            lblFechaReporteInicio.BackColor = Color.Transparent;
            lblFechaReporteInicio.Font = new Font("Segoe UI", 11F);
            lblFechaReporteInicio.ForeColor = Color.FromArgb(76, 76, 77);
            lblFechaReporteInicio.Location = new Point(96, 115);
            lblFechaReporteInicio.Name = "lblFechaReporteInicio";
            lblFechaReporteInicio.Size = new Size(51, 20);
            lblFechaReporteInicio.TabIndex = 3;
            lblFechaReporteInicio.Text = "Desde";
            // 
            // lblReporteTitulo
            // 
            lblReporteTitulo.AutoSize = true;
            lblReporteTitulo.BackColor = Color.Transparent;
            lblReporteTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReporteTitulo.ForeColor = Color.FromArgb(76, 76, 77);
            lblReporteTitulo.Location = new Point(157, 39);
            lblReporteTitulo.Name = "lblReporteTitulo";
            lblReporteTitulo.Size = new Size(401, 25);
            lblReporteTitulo.TabIndex = 2;
            lblReporteTitulo.Text = "Seleccione un periodo para generar el reporte";
            // 
            // dtpFechaReporteFinal
            // 
            dtpFechaReporteFinal.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpFechaReporteFinal.Format = DateTimePickerFormat.Short;
            dtpFechaReporteFinal.Location = new Point(415, 138);
            dtpFechaReporteFinal.MinimumSize = new Size(0, 29);
            dtpFechaReporteFinal.Name = "dtpFechaReporteFinal";
            dtpFechaReporteFinal.Size = new Size(200, 29);
            dtpFechaReporteFinal.TabIndex = 1;
            // 
            // dtpFechaReporteInicio
            // 
            dtpFechaReporteInicio.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpFechaReporteInicio.Format = DateTimePickerFormat.Short;
            dtpFechaReporteInicio.Location = new Point(96, 138);
            dtpFechaReporteInicio.MinimumSize = new Size(0, 29);
            dtpFechaReporteInicio.Name = "dtpFechaReporteInicio";
            dtpFechaReporteInicio.Size = new Size(200, 29);
            dtpFechaReporteInicio.TabIndex = 0;
            // 
            // pnlMasterMenu
            // 
            pnlMasterMenu.BackColor = Color.FromArgb(255, 255, 255);
            pnlMasterMenu.Controls.Add(mbtnGenerarReporte);
            pnlMasterMenu.Controls.Add(mbtnEstadisticas);
            pnlMasterMenu.Controls.Add(pnlSubMenuReportes);
            pnlMasterMenu.Controls.Add(mbtnMenuReportes);
            pnlMasterMenu.Controls.Add(mbtnSalir);
            pnlMasterMenu.Controls.Add(mbtnRegistroUsuarios);
            pnlMasterMenu.Controls.Add(mbtnListaUsuarios);
            pnlMasterMenu.Depth = 0;
            pnlMasterMenu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnlMasterMenu.Location = new Point(17, 14);
            pnlMasterMenu.Margin = new Padding(15, 13, 15, 13);
            pnlMasterMenu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            pnlMasterMenu.Name = "pnlMasterMenu";
            pnlMasterMenu.Padding = new Padding(15, 13, 15, 13);
            pnlMasterMenu.Size = new Size(222, 456);
            pnlMasterMenu.TabIndex = 5;
            // 
            // mbtnGenerarReporte
            // 
            mbtnGenerarReporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnGenerarReporte.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnGenerarReporte.Depth = 0;
            mbtnGenerarReporte.Dock = DockStyle.Top;
            mbtnGenerarReporte.HighEmphasis = true;
            mbtnGenerarReporte.Icon = null;
            mbtnGenerarReporte.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnGenerarReporte.Location = new Point(15, 285);
            mbtnGenerarReporte.Margin = new Padding(4);
            mbtnGenerarReporte.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnGenerarReporte.Name = "mbtnGenerarReporte";
            mbtnGenerarReporte.NoAccentTextColor = Color.Empty;
            mbtnGenerarReporte.Size = new Size(192, 36);
            mbtnGenerarReporte.TabIndex = 9;
            mbtnGenerarReporte.Text = "Generar Reporte";
            mbtnGenerarReporte.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnGenerarReporte.UseAccentColor = false;
            mbtnGenerarReporte.UseVisualStyleBackColor = true;
            mbtnGenerarReporte.Click += MbtnGenerarReporte_Click;
            // 
            // mbtnEstadisticas
            // 
            mbtnEstadisticas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnEstadisticas.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnEstadisticas.Depth = 0;
            mbtnEstadisticas.Dock = DockStyle.Top;
            mbtnEstadisticas.HighEmphasis = true;
            mbtnEstadisticas.Icon = null;
            mbtnEstadisticas.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnEstadisticas.ImageAlign = ContentAlignment.TopCenter;
            mbtnEstadisticas.Location = new Point(15, 249);
            mbtnEstadisticas.Margin = new Padding(4);
            mbtnEstadisticas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnEstadisticas.Name = "mbtnEstadisticas";
            mbtnEstadisticas.NoAccentTextColor = Color.Empty;
            mbtnEstadisticas.Size = new Size(192, 36);
            mbtnEstadisticas.TabIndex = 6;
            mbtnEstadisticas.Text = "Estadisticas";
            mbtnEstadisticas.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnEstadisticas.UseAccentColor = false;
            mbtnEstadisticas.UseVisualStyleBackColor = true;
            mbtnEstadisticas.Click += BtnOpcionEstadistica_Click;
            // 
            // pnlSubMenuReportes
            // 
            pnlSubMenuReportes.BackColor = Color.FromArgb(255, 255, 255);
            pnlSubMenuReportes.Controls.Add(mbtnReportesRevision);
            pnlSubMenuReportes.Controls.Add(mbtnSuspendidos);
            pnlSubMenuReportes.Controls.Add(mbtnReportados);
            pnlSubMenuReportes.Depth = 0;
            pnlSubMenuReportes.Dock = DockStyle.Top;
            pnlSubMenuReportes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnlSubMenuReportes.Location = new Point(15, 121);
            pnlSubMenuReportes.Margin = new Padding(15, 13, 15, 13);
            pnlSubMenuReportes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            pnlSubMenuReportes.Name = "pnlSubMenuReportes";
            pnlSubMenuReportes.Padding = new Padding(15, 13, 15, 13);
            pnlSubMenuReportes.Size = new Size(192, 128);
            pnlSubMenuReportes.TabIndex = 5;
            // 
            // mbtnReportesRevision
            // 
            mbtnReportesRevision.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnReportesRevision.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnReportesRevision.Depth = 0;
            mbtnReportesRevision.Dock = DockStyle.Top;
            mbtnReportesRevision.HighEmphasis = true;
            mbtnReportesRevision.Icon = null;
            mbtnReportesRevision.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnReportesRevision.Location = new Point(15, 85);
            mbtnReportesRevision.Margin = new Padding(4);
            mbtnReportesRevision.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnReportesRevision.Name = "mbtnReportesRevision";
            mbtnReportesRevision.NoAccentTextColor = Color.Empty;
            mbtnReportesRevision.Size = new Size(162, 36);
            mbtnReportesRevision.TabIndex = 7;
            mbtnReportesRevision.Text = "Reportes en Revision";
            mbtnReportesRevision.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnReportesRevision.UseAccentColor = false;
            mbtnReportesRevision.UseVisualStyleBackColor = true;
            // 
            // mbtnSuspendidos
            // 
            mbtnSuspendidos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnSuspendidos.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSuspendidos.Depth = 0;
            mbtnSuspendidos.Dock = DockStyle.Top;
            mbtnSuspendidos.HighEmphasis = true;
            mbtnSuspendidos.Icon = null;
            mbtnSuspendidos.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnSuspendidos.Location = new Point(15, 49);
            mbtnSuspendidos.Margin = new Padding(4);
            mbtnSuspendidos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnSuspendidos.Name = "mbtnSuspendidos";
            mbtnSuspendidos.NoAccentTextColor = Color.Empty;
            mbtnSuspendidos.Size = new Size(162, 36);
            mbtnSuspendidos.TabIndex = 4;
            mbtnSuspendidos.Text = "Usuarios Suspendidos";
            mbtnSuspendidos.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSuspendidos.UseAccentColor = false;
            mbtnSuspendidos.UseVisualStyleBackColor = true;
            // 
            // mbtnReportados
            // 
            mbtnReportados.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnReportados.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnReportados.Depth = 0;
            mbtnReportados.Dock = DockStyle.Top;
            mbtnReportados.HighEmphasis = true;
            mbtnReportados.Icon = null;
            mbtnReportados.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnReportados.Location = new Point(15, 13);
            mbtnReportados.Margin = new Padding(4);
            mbtnReportados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnReportados.Name = "mbtnReportados";
            mbtnReportados.NoAccentTextColor = Color.Empty;
            mbtnReportados.Size = new Size(162, 36);
            mbtnReportados.TabIndex = 8;
            mbtnReportados.Text = "Usuarios Reportados";
            mbtnReportados.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnReportados.UseAccentColor = false;
            mbtnReportados.UseVisualStyleBackColor = true;
            // 
            // mbtnMenuReportes
            // 
            mbtnMenuReportes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnMenuReportes.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnMenuReportes.Depth = 0;
            mbtnMenuReportes.Dock = DockStyle.Top;
            mbtnMenuReportes.HighEmphasis = true;
            mbtnMenuReportes.Icon = null;
            mbtnMenuReportes.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnMenuReportes.Location = new Point(15, 85);
            mbtnMenuReportes.Margin = new Padding(4);
            mbtnMenuReportes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnMenuReportes.Name = "mbtnMenuReportes";
            mbtnMenuReportes.NoAccentTextColor = Color.Empty;
            mbtnMenuReportes.Size = new Size(192, 36);
            mbtnMenuReportes.TabIndex = 3;
            mbtnMenuReportes.Text = "Reportes";
            mbtnMenuReportes.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnMenuReportes.UseAccentColor = false;
            mbtnMenuReportes.UseVisualStyleBackColor = true;
            mbtnMenuReportes.Click += BtnOpcionReportes_Click;
            // 
            // mbtnSalir
            // 
            mbtnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnSalir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSalir.Depth = 0;
            mbtnSalir.Dock = DockStyle.Bottom;
            mbtnSalir.HighEmphasis = true;
            mbtnSalir.Icon = null;
            mbtnSalir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnSalir.Location = new Point(15, 407);
            mbtnSalir.Margin = new Padding(4);
            mbtnSalir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnSalir.Name = "mbtnSalir";
            mbtnSalir.NoAccentTextColor = Color.Empty;
            mbtnSalir.Size = new Size(192, 36);
            mbtnSalir.TabIndex = 2;
            mbtnSalir.Text = "Log Out";
            mbtnSalir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSalir.UseAccentColor = false;
            mbtnSalir.UseVisualStyleBackColor = true;
            mbtnSalir.Click += BtnSalir_Click;
            // 
            // mbtnRegistroUsuarios
            // 
            mbtnRegistroUsuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnRegistroUsuarios.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnRegistroUsuarios.Depth = 0;
            mbtnRegistroUsuarios.Dock = DockStyle.Top;
            mbtnRegistroUsuarios.HighEmphasis = true;
            mbtnRegistroUsuarios.Icon = null;
            mbtnRegistroUsuarios.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnRegistroUsuarios.Location = new Point(15, 49);
            mbtnRegistroUsuarios.Margin = new Padding(4);
            mbtnRegistroUsuarios.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnRegistroUsuarios.Name = "mbtnRegistroUsuarios";
            mbtnRegistroUsuarios.NoAccentTextColor = Color.Empty;
            mbtnRegistroUsuarios.Size = new Size(192, 36);
            mbtnRegistroUsuarios.TabIndex = 1;
            mbtnRegistroUsuarios.Text = "Registrar Usuario";
            mbtnRegistroUsuarios.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnRegistroUsuarios.UseAccentColor = false;
            mbtnRegistroUsuarios.UseVisualStyleBackColor = true;
            mbtnRegistroUsuarios.Click += BtnMenuRegistroUsuarios_Click;
            // 
            // mbtnListaUsuarios
            // 
            mbtnListaUsuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnListaUsuarios.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnListaUsuarios.Depth = 0;
            mbtnListaUsuarios.Dock = DockStyle.Top;
            mbtnListaUsuarios.HighEmphasis = true;
            mbtnListaUsuarios.Icon = null;
            mbtnListaUsuarios.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtnListaUsuarios.Location = new Point(15, 13);
            mbtnListaUsuarios.Margin = new Padding(4);
            mbtnListaUsuarios.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtnListaUsuarios.Name = "mbtnListaUsuarios";
            mbtnListaUsuarios.NoAccentTextColor = Color.Empty;
            mbtnListaUsuarios.Size = new Size(192, 36);
            mbtnListaUsuarios.TabIndex = 0;
            mbtnListaUsuarios.Text = "Lista de Usuarios";
            mbtnListaUsuarios.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnListaUsuarios.UseAccentColor = false;
            mbtnListaUsuarios.UseVisualStyleBackColor = true;
            mbtnListaUsuarios.Click += BtnOpcionListaUsuario_Click;
            // 
            // FrmPanelCodeplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 489);
            Controls.Add(pnlMasterMenu);
            Controls.Add(grpMasterMenu);
            Controls.Add(lblBienvenida);
            Name = "FrmPanelCodeplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPanelCodeplay";
            Load += FrmPanelCodeplay_Load;
            pnlMenuEstadisticas.ResumeLayout(false);
            pnlMenuListaUsuario.ResumeLayout(false);
            pnlSubListaUsuariosOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            grpMasterMenu.ResumeLayout(false);
            pnlMenuGenerarReporte.ResumeLayout(false);
            pnlMenuGenerarReporte.PerformLayout();
            pnlMasterMenu.ResumeLayout(false);
            pnlMasterMenu.PerformLayout();
            pnlSubMenuReportes.ResumeLayout(false);
            pnlSubMenuReportes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private ReaLTaiizor.Controls.MaterialCard pnlMasterMenu;
        private ReaLTaiizor.Controls.MaterialButton mbtnSuspendidos;
        private ReaLTaiizor.Controls.MaterialButton mbtnMenuReportes;
        private ReaLTaiizor.Controls.MaterialButton mbtnSalir;
        private ReaLTaiizor.Controls.MaterialButton mbtnRegistroUsuarios;
        private ReaLTaiizor.Controls.MaterialButton mbtnListaUsuarios;
        private ReaLTaiizor.Controls.MaterialButton mbtnGenerarReporte;
        private ReaLTaiizor.Controls.MaterialButton mbtnReportesRevision;
        private ReaLTaiizor.Controls.MaterialButton mbtnEstadisticas;
        private ReaLTaiizor.Controls.MaterialCard pnlSubMenuReportes;
        private ReaLTaiizor.Controls.MaterialButton mbtnReportados;
        private Panel pnlMenuGenerarReporte;
        private ReaLTaiizor.Controls.DungeonLabel lblReporteTitulo;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaReporteFinal;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaReporteInicio;
        private ReaLTaiizor.Controls.MaterialButton btnGenerarReporte;
        private ReaLTaiizor.Controls.DungeonLabel lblFechaReporteFinal;
        private ReaLTaiizor.Controls.DungeonLabel lblFechaReporteInicio;
    }
}