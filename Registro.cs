using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase sin usar, posible clase innecesaria, considerar borrarlo en el futuro

namespace Registro_de_ventas_Codeplay
{
    public class Registro
    {
        private string nombreUsuario = string.Empty;

        public DateTime fechaNacimiento {  get; set; }

        private string correoElectronico = string.Empty;

        private string pais = string.Empty;

        private string contrasenia = string.Empty;

        public string NombreUsuario
        {
            get => nombreUsuario;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre es obligatorio");

                nombreUsuario = value.Trim();
            }
        }
            public string CorreoElectronico
        {
                get => correoElectronico;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El correo es obligatorio.");
                correoElectronico= value.Trim();
            }

        }

        public  string Pais 
        {
            get => pais;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El pais es obligatorio");
                pais = value.Trim();
            }
        }

        public string Contrasenia
        {
            get => contrasenia;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El pais es obligatorio");
                contrasenia = value.Trim();
            }
        }


    }
}
