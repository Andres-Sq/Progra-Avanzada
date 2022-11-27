using System;
using System.Collections.Generic;

namespace Entidades.Entidad
{
    public partial class RutaChofer
    {
        public int Id { get; set; }
        public int CodEmpleado { get; set; }
        public string NombreRuta { get; set; }
        public int CantidadPasajeros { get; set; }
        public int MontoPasaje { get; set; }
        public int? Total { get; set; }

        public virtual Choferes CodEmpleadoNavigation { get; set; }
        public virtual Ruta Ruta { get; set; }
    }
}
