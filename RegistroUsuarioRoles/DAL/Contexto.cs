using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RegistroUsuarioRoles.Entidades;

namespace RegistroUsuarioRoles.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Roll> Roll { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionUsuario.Db");
        }
    }
}
