using Entidades.Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/RutaChofer")]
    [ApiController]
    public class RutaChoferController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public RutaChoferController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region RutaChofer
        [HttpPost]
        [Route(nameof(AgregarRutaChofer))]
        public bool AgregarRutaChofer(RutaChofer P_Entidad)
        {
            return _inegocioSQL.AgregarRutaChofer(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarRutaChofer))]
        public List<RutaChofer> ConsultarRutaChofer(RutaChofer P_Entidad)
        {
            return _inegocioSQL.ConsultarRutaChofer(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarRutaChofer))]
        public bool ModificarRutaChofer(RutaChofer P_Entidad)
        {
            return _inegocioSQL.ModificarRutaChofer(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarRutaChofer))]
        public bool EliminarRutaChofer(RutaChofer P_Entidad)
        {
            return _inegocioSQL.EliminarRutaChofer(P_Entidad);
        }
        #endregion
    }
}
