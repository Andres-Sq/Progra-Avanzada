using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Models
{
    public class Ruta
    {
        #region Propiedades
        public int Id { get; set; }
        public string NombreRuta { get; set; }
        public int CantidadParadas { get; set; }
        public int MontoPasaje { get; set; }
        #endregion

        #region Constructor
        public Ruta()
        {
            Id = 0;
            NombreRuta = string.Empty;
            CantidadParadas = 0;
            MontoPasaje = 0;
        }
        #endregion
    }
}
