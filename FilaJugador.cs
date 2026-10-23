using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_ventas_Codeplay
{
    public partial class FilaJugador : UserControl
    {
        public FilaJugador()
        {
            InitializeComponent();

            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                
            }
        }
    }
}
