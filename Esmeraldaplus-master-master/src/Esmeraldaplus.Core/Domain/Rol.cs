using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class Rol
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdRol { get; set; }
        public string TipoDeRol { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
