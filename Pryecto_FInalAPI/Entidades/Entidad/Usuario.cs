using System;
using System.Collections.Generic;

namespace Entidades.Entidad
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public int Cedula { get; set; }
        public string Clave { get; set; }
        public int Perfil { get; set; }

        public virtual PerfilAsignado PerfilNavigation { get; set; }
    }
}
