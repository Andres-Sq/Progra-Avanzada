using Entidades.Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/Unidades")]
    [ApiController]
    public class UnidadesController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public UnidadesController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Unidades
        [HttpPost]
        [Route(nameof(AgregarUnidades))]
        public bool AgregarUnidades(Unidades P_Entidad)
        {
            return _inegocioSQL.AgregarUnidades(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarUnidades))]
        public List<Unidades> ConsultarUnidades(Unidades P_Entidad)
        {
            return _inegocioSQL.ConsultarUnidades(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarUnidades))]
        public bool ModificarUnidades(Unidades P_Entidad)
        {
            return _inegocioSQL.ModificarUnidades(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarUnidades))]
        public bool EliminarUnidades(Unidades P_Entidad)
        {
            return _inegocioSQL.EliminarUnidades(P_Entidad);
        }
        #endregion
    }
}
