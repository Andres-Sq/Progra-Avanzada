using Entidades.Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/PerfilAsignado")]
    [ApiController]
    public class PerfilAsignadoController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public PerfilAsignadoController (INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region PerfilAsignado
        [HttpPost]
        [Route(nameof(ConsultarPerfilAsignado))]
        public List<PerfilAsignado> ConsultarPerfilAsignado(PerfilAsignado P_Entidad)
        {
            return _inegocioSQL.ConsultarPerfilAsignado(P_Entidad).ToList();
        }
        #endregion
    }
}
