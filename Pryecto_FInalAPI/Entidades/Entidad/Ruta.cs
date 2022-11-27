using System;
using System.Collections.Generic;

namespace Entidades.Entidad
{
    public partial class Ruta
    {
        public Ruta()
        {
            RutaChofer = new HashSet<RutaChofer>();
        }

        public int Id { get; set; }
        public string NombreRuta { get; set; }
        public int CantidadParadas { get; set; }
        public int MontoPasaje { get; set; }

        public virtual ICollection<RutaChofer> RutaChofer { get; set; }
    }
}
