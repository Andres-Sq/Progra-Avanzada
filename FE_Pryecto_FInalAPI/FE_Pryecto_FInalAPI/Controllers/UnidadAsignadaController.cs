using FE_Pryecto_FInalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Controllers
{
    public class UnidadAsignadaController : Controller
    {
        #region Vista y Carga de datos
        public async Task<IActionResult> ListarUnidadAsignada()
        {
            ConexionAPI objconexion = new ConexionAPI();
            List<UnidadAsignada> lstunidadasignada = await objconexion.ConsultarUnidadAsignada(new UnidadAsignada());
            return View(lstunidadasignada);
        }
        public IActionResult AbrirNuevaUnidadAsignada()
        {
            return View();
        }
        public IActionResult AbrirModificarUnidadAsignada(int id, int codempleado, string placa)
        {
            UnidadAsignada objunidadasignada = new UnidadAsignada
            {
                Id = id,
                CodEmpleado= codempleado,
                Placa = placa,
            };

            return View(objunidadasignada);
        }
        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> AgregarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.AgregarUnidadAsignada(P_Entidad);
            return RedirectToAction("ListarUnidadAsignada", "UnidadAsignada");
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarUnidadAsignada(int codempleado)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ConsultarUnidadAsignada(new UnidadAsignada { CodEmpleado = codempleado });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModificarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ModificarUnidadAsignada(P_Entidad);
            return RedirectToAction("ListarUnidadAsignada", "UnidadAsignada");
        }
        public async Task<IActionResult> EliminarUnidadAsignada(int id)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.EliminarUnidadAsignada(new UnidadAsignada { Id = id });
            return RedirectToAction("ListarUnidadAsignada", "UnidadAsignada");
        }
        #endregion

    }
}
