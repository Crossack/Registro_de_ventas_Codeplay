namespace Registro_de_ventas_Codeplay
{
    partial class RecuperarContraseña
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
            lblPregunta = new Label();
            txtPelicula = new TextBox();
            btnRecuperarPassword = new Button();
            btnCancelar = new Button();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "&Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(116, 67);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(175, 27);
            txtUsuario.TabIndex = 1;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(177, 140);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(68, 20);
            lblPregunta.TabIndex = 2;
            lblPregunta.Text = "&Pregunta";
            // 
            // txtPelicula
            // 
            txtPelicula.Location = new Point(116, 172);
            txtPelicula.Name = "txtPelicula";
            txtPelicula.Size = new Size(175, 27);
            txtPelicula.TabIndex = 3;
            // 
            // btnRecuperarPassword
            // 
            btnRecuperarPassword.Location = new Point(46, 250);
            btnRecuperarPassword.Name = "btnRecuperarPassword";
            btnRecuperarPassword.Size = new Size(94, 29);
            btnRecuperarPassword.TabIndex = 4;
            btnRecuperarPassword.Text = "&Recuperar";
            btnRecuperarPassword.UseVisualStyleBackColor = true;
            btnRecuperarPassword.Click += btnRecuperarPassword_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(251, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(314, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // RecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 316);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnRecuperarPassword);
            Controls.Add(txtPelicula);
            Controls.Add(lblPregunta);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "RecuperarContraseña";
            Text = "RecuperarContraseña";
            Load += RecuperarContraseña_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label lblPregunta;
        private TextBox txtPelicula;
        private Button btnRecuperarPassword;
        private Button btnCancelar;
        private Button btnBuscar;
    }
}