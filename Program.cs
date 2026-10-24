using System;
using System.Windows.Forms;
using Registro_de_ventas_Codeplay.Models; // Necesario para leer SesionActiva

namespace Registro_de_ventas_Codeplay
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FrmInicioSesion Login = new FrmInicioSesion())
            {
                if (Login.ShowDialog() == DialogResult.OK)
                {
                    // Verificamos si el rol guardado en SesionActiva es Administrador
                    bool esAdmin = string.Equals(SesionActiva.RolUsuario?.Trim(), "Admin", StringComparison.OrdinalIgnoreCase) ||
                                   string.Equals(SesionActiva.RolUsuario?.Trim(), "Administrador", StringComparison.OrdinalIgnoreCase);

                    if (esAdmin)
                    {
                        // Si cumple los requisitos, arranca directamente en el nuevo panel de Admin
                        Application.Run(new FrmPanelCodeplay());
                    }
                    else
                    {
                        // Si es usuario normal, abre tu formulario frmRegistros original
                        Application.Run(new frmRegistros());
                    }
                }
            }
        }
    }
}