using System;
using System.Collections.Generic;

namespace Entidades.Entidad
{
    public partial class Choferes
    {
        public Choferes()
        {
            RutaChofer = new HashSet<RutaChofer>();
            UnidadAsignada = new HashSet<UnidadAsignada>();
        }

        public int Id { get; set; }
        public int CodEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime ExpLicencia { get; set; }

        public virtual ICollection<RutaChofer> RutaChofer { get; set; }
        public virtual ICollection<UnidadAsignada> UnidadAsignada { get; set; }
    }
}
