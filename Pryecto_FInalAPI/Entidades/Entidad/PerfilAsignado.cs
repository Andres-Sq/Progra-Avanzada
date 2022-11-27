using System;
using System.Collections.Generic;

namespace Entidades.Entidad
{
    public partial class PerfilAsignado
    {
        public PerfilAsignado()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int Perfil { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
