﻿using Entidades.Entidad;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/Choferes")]
    [ApiController]
    public class ChoferesController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public ChoferesController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Choferes
        [HttpPost]
        [Route(nameof(AgregarChoferes))]
        public bool AgregarChoferes(Choferes P_Entidad)
        {
            return _inegocioSQL.AgregarChoferes(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarChoferes))]
        public List<Choferes> ConsultarChoferes(Choferes P_Entidad)
        {
            return _inegocioSQL.ConsultarChoferes(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarChoferes))]
        public bool ModificarChoferes(Choferes P_Entidad)
        {
            return _inegocioSQL.ModificarChoferes(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarChoferes))]
        public bool EliminarChoferes(Choferes P_Entidad)
        {
            return _inegocioSQL.EliminarChoferes(P_Entidad);
        }
        #endregion
    }
}
