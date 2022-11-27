using FE_Pryecto_FInalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Controllers
{
    public class RutaChoferController : Controller
    {
        #region Vista y Carga de datos
        public async Task<IActionResult> ListarRutaChofer()
        {
            ConexionAPI objconexion = new ConexionAPI();
            List<RutaChofer> lstrutachofer = await objconexion.ConsultarRutaChofer(new RutaChofer());
            return View(lstrutachofer);
        }
        public IActionResult AbrirNuevaRutaChofer()
        {
            return View();
        }
        public IActionResult AbrirModificarRutaChofer(int id, int codempleado, string nombreruta, int cantidadpasajeros, int montopasaje, int total)
        {
            RutaChofer objrutachofer = new RutaChofer
            {
                Id = id,
                CodEmpleado = codempleado,
                NombreRuta = nombreruta,
                CantidadPasajeros = cantidadpasajeros,
                MontoPasaje = montopasaje,
                Total = total,
            };

            return View(objrutachofer);
        }
        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> AgregarRutaChofer(RutaChofer P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.AgregarRutaChofer(P_Entidad);
            return RedirectToAction("ListarRutaChofer", "RutaChofer");
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarRutaChofer(int CodEmpleado)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ConsultarRutaChofer(new RutaChofer { CodEmpleado = CodEmpleado });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModificarRutaChofer(RutaChofer P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ModificarRutaChofer(P_Entidad);
            return RedirectToAction("ListarRutaChofer", "RutaChofer");
        }
        public async Task<IActionResult> EliminarRutaChofer(int codempleado, string nombreruta, int montopasaje)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.EliminarRutaChofer(new RutaChofer { CodEmpleado = codempleado, NombreRuta = nombreruta, MontoPasaje = montopasaje });
            return RedirectToAction("ListarRutaChofer", "RutaChofer");
        }
        #endregion
    }
}
