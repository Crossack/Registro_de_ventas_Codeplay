using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Business
{
    public class Hasher
    {
        public static string GenerarHashSHA256(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                // Calcular el hash
                byte[] bytesOriginal = Encoding.UTF8.GetBytes(text);
                byte[] bytesHash = sha256.ComputeHash(bytesOriginal);

                // Convertir el hash a formato hexadecimal legible (64 caracteres)
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytesHash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
