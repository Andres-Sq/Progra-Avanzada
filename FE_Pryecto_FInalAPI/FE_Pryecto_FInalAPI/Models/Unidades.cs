using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Models
{
    public class Unidades
    {
        #region Propiedades
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Placa { get; set; }
        #endregion

        #region Constructor
        public Unidades()
        {
            Id = 0;
            Estado = string.Empty;
            Placa = string.Empty;
        }
        #endregion
    }
}
