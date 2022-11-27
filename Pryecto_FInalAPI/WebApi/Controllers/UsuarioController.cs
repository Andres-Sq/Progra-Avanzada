using Entidades.Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public UsuarioController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Usuario
        [HttpPost]
        [Route(nameof(AgregarUsuario))]
        public bool AgregarUsuario(Usuario P_Entidad)
        {
            return _inegocioSQL.AgregarUsuario(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarUsuario))]
        public List<Usuario> ConsultarUsuario(Usuario P_Entidad)
        {
            return _inegocioSQL.ConsultarUsuario(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(EliminarUsuario))]
        public bool EliminarUsuario(Usuario P_Entidad)
        {
            return _inegocioSQL.EliminarUsuario(P_Entidad);
        }
        #endregion
    }
}
