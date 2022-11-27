using FE_Pryecto_FInalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Controllers
{
    public class RutaController : Controller
    {
        #region Vista y Carga de datos
        public async Task<IActionResult> ListarRutas()
        {
            ConexionAPI objconexion = new ConexionAPI();
            List<Ruta> lstruta = await objconexion.ConsultarRuta(new Ruta());
            return View(lstruta);
        }
        public IActionResult AbrirNuevaRuta()
        {
            return View();
        }
        public IActionResult AbrirModificarRuta(int id, string nombreruta, int cantidadparadas, int montopasaje)
        {
            Ruta objruta = new Ruta
            {
                Id = id,
                NombreRuta = nombreruta,
                CantidadParadas = cantidadparadas,
                MontoPasaje = montopasaje,
            };

            return View(objruta);
        }
        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> AgregarRuta(Ruta P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.AgregarRuta(P_Entidad);
            return RedirectToAction("ListarRutas", "Ruta");
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarRuta(int id)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ConsultarRuta(new Ruta { Id = id });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModificarRuta(Ruta P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ModificarRuta(P_Entidad);
            return RedirectToAction("ListarRutas", "Ruta");
        }
        public async Task<IActionResult> EliminarRuta(string nombreruta, int montopasaje)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.EliminarRuta(new Ruta { NombreRuta = nombreruta, MontoPasaje = montopasaje });
            return RedirectToAction("ListarRutas", "Ruta");
        }
        #endregion
    }
}
