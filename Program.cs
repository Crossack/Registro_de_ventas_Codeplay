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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FrmInicioSesion Login = new FrmInicioSesion())
            {
                if (Login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmRegistros());
                }
            }
        }
    }
}