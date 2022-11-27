using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Models
{
    public class UnidadAsignada
    {
        #region Propiedades
        public int Id { get; set; }
        public int CodEmpleado { get; set; }
        public string Placa { get; set; }
        #endregion

        #region Constructor
        public UnidadAsignada()
        {
            Id = 0;
            CodEmpleado = 0;
            Placa = string.Empty;
        }
        #endregion
    }
}
