using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Models
{
    public class PerfilAsignado
    {
        #region Propiedades
        public int Perfil { get; set; }
        public string Tipo { get; set; }
        #endregion
        #region Constructor
        public PerfilAsignado()
        {
            Perfil = 0;
            Tipo = string.Empty;
        }
        #endregion
    }
}
