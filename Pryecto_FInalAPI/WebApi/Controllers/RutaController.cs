using Entidades.Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/Ruta")]
    [ApiController]
    public class RutaController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public RutaController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Ruta
        [HttpPost]
        [Route(nameof(AgregarRuta))]
        public bool AgregarRuta(Ruta P_Entidad)
        {
            return _inegocioSQL.AgregarRuta(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarRuta))]
        public List<Ruta> ConsultarRuta(Ruta P_Entidad)
        {
            return _inegocioSQL.ConsultarRuta(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarRuta))]
        public bool ModificarRuta(Ruta P_Entidad)
        {
            return _inegocioSQL.ModificarRuta(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarRuta))]
        public bool EliminarRuta(Ruta P_Entidad)
        {
            return _inegocioSQL.EliminarRuta(P_Entidad);
        }
        #endregion
    }
}
