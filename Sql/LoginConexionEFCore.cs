using Microsoft.EntityFrameworkCore;
using Registro_de_ventas_Codeplay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_ventas_Codeplay.Sql
{
    public class LoginConexionEFCore : DbContext
    {
        private const string archivoConexion = "conexion.txt";
        public DbSet<LoginUsuario> LoginUsuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        private static string ObtenerConexion()
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, archivoConexion);

            if (!File.Exists(ruta))
            {
                string plantilla = """Server=localhost\SQLEXPRESS;""" +
                    "Database=BDRegistroVentas;" +
                    "Trusted_Connection=True;" +
                    "TrustServerCertificate=True;";
                File.WriteAllText(ruta, plantilla);

                MessageBox.Show(
                    $"No se encontró el archivo '{archivoConexion}'.\n" +
                    "Se ha creado uno de ejemplo en la carpeta de ejecución.\n" +
                    "Por favor revisa la cadena de conexión.",
                    "Configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return plantilla;
            }

            return File.ReadAllText(ruta).Trim();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            if (!opciones.IsConfigured)
            {
                opciones.UseSqlServer(ObtenerConexion());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Roles");
                entity.HasKey(r => r.IdRol);
                entity.Property(r => r.IdRol).HasColumnName("IdRol");
                entity.Property(r => r.NombreRol).HasColumnName("Nombre").IsRequired();
            });

            modelBuilder.Entity<LoginUsuario>(entity =>
            {
                entity.ToTable("LoginUsuarios");

                // Definición de la Llave Primaria
                entity.HasKey(u => u.Id);

                // Mapeo de columnas
                entity.Property(u => u.Id)
                      .HasColumnName("IdUsuario");

                entity.Property(u => u.Nombre)
                      .HasColumnName("NombreUsuario")
                      .HasMaxLength(50)
                      .IsRequired();

                entity.Property(u => u.Contraseña)
                      .HasColumnName("PasswordHash")
                      .IsRequired();

                entity.Property(u => u.IdRol)
                      .HasColumnName("IdRol")
                      .IsRequired();

                entity.Property(u => u.PreguntaRec)
                      .HasColumnName("PreguntaRec")
                      .IsRequired();

                entity.HasOne(u => u.Rol)
                      .WithMany()
                      .HasForeignKey(u => u.IdRol);
            });
        }
    }
}
