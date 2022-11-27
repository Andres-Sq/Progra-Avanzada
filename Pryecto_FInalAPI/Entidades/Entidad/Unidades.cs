using System;
using System.Collections.Generic;

namespace Entidades.Entidad
{
    public partial class Unidades
    {
        public Unidades()
        {
            UnidadAsignada = new HashSet<UnidadAsignada>();
        }

        public int Id { get; set; }
        public string Estado { get; set; }
        public string Placa { get; set; }

        public virtual ICollection<UnidadAsignada> UnidadAsignada { get; set; }
    }
}
