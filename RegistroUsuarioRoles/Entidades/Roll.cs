using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistroUsuarioRoles.Entidades
{
    public class Roll
    {
        [Key]
        public int RolliD { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fechacreacion { get; set; }

        public Roll()
        {

        }

    }
}
