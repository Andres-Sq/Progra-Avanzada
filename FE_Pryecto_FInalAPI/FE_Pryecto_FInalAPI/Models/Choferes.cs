using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Models
{
    public class Choferes
    {
        #region Propiedades
        public int Id { get; set; }
        public int CodEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime ExpLicencia { get; set; }
        #endregion

        #region Constructor
        public Choferes()
        {
            Id = 0;
            CodEmpleado = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            ExpLicencia = DateTime.MinValue;
        }
        #endregion
    }
}
