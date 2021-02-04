using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroUsuarioRoles.Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Alias { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }
        public string UsuarioNombre { get; set; }

        [ForeignKey("Rolid")]
        public virtual Roll roles { get; set; }

        public Usuario()
        {
            UsuarioId = 0;
            FechaIngreso = DateTime.Now;
            Alias = string.Empty;
            Nombres = string.Empty;
            Email = string.Empty;
            Clave = string.Empty;
            Activo = false;
            UsuarioNombre = string.Empty;
        }
        }
    }
