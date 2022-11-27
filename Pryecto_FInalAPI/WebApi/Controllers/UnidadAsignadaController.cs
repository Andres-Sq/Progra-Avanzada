using Entidades.Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/UnidadAsignada")]
    [ApiController]
    public class UnidadAsignadaController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public UnidadAsignadaController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region UnidadAsignada
        [HttpPost]
        [Route(nameof(AgregarUnidadAsignada))]
        public bool AgregarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            return _inegocioSQL.AgregarUnidadAsignada(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarUnidadAsignada))]
        public List<UnidadAsignada> ConsultarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            return _inegocioSQL.ConsultarUnidadAsignada(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarUnidadAsignada))]
        public bool ModificarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            return _inegocioSQL.ModificarUnidadAsignada(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarUnidadAsignada))]
        public bool EliminarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            return _inegocioSQL.EliminarUnidadAsignada(P_Entidad);
        }
        #endregion
    }
}
