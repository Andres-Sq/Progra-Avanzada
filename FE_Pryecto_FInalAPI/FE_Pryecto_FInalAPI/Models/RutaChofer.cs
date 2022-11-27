using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Models
{
    public class RutaChofer
    {
        #region Propiedades
        public int Id { get; set; }
        public int CodEmpleado { get; set; }
        public string NombreRuta { get; set; }
        public int CantidadPasajeros { get; set; }
        public int MontoPasaje { get; set; }
        public int? Total { get; set; }
        #endregion

        #region Constructor
        public RutaChofer()
        {
            Id = 0;
            CodEmpleado = 0;
            NombreRuta = string.Empty;
            CantidadPasajeros = 0;
            MontoPasaje = 0;
            Total = 0;
        }
        #endregion
    }
}
