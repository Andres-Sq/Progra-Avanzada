using System;
using System.Collections.Generic;

namespace Entidades.Entidad
{
    public partial class UnidadAsignada
    {
        public int Id { get; set; }
        public int CodEmpleado { get; set; }
        public string Placa { get; set; }

        public virtual Choferes CodEmpleadoNavigation { get; set; }
        public virtual Unidades PlacaNavigation { get; set; }
    }
}
