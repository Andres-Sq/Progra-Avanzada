using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Models
{
    public class Usuario
    {
        #region Propiedades
        public int Id { get; set; }
        public int Cedula { get; set; }
        public string Clave { get; set; }
        public int Perfil { get; set; }
        #endregion

        #region Constructor
        public Usuario()
        {
            Id = 0;
            Cedula = 0;
            Clave = string.Empty;
            Perfil = 3;
        }
        #endregion

        public Usuario ValidarUsuario()
        {
            Usuario estado = new Usuario();
            return estado;
        }
    }
}
