using FE_Pryecto_FInalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Controllers
{
    public class ChoferesController : Controller
    {
        #region Vista y Carga de datos
        public async Task<IActionResult> ListarChoferes()
        {
            ConexionAPI objconexion = new ConexionAPI();
            List<Choferes> lstchoferes = await objconexion.ConsultarChoferes(new Choferes());
            return View(lstchoferes);
        }
        public IActionResult AbrirNuevoChoferes()
        {
            return View();
        }
        public IActionResult AbrirModificarUnidadAsignada(int id, int codempleado, string nombre, string apellido, string explicencia)
        {
            Choferes objchoferes = new Choferes
            {
                Id = id,
                CodEmpleado = codempleado,
                Nombre = nombre,
                Apellido = apellido,
                ExpLicencia = DateTime.ParseExact(explicencia, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
            };

            return View(objchoferes);
        }
        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> AgregarChoferes(Choferes P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.AgregarChoferes(P_Entidad);
            return RedirectToAction("ListarChoferes", "Choferes");
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarChoferes(int codempleado)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ConsultarChoferes(new Choferes { CodEmpleado = codempleado });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModificarChoferes(Choferes P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ModificarChoferes(P_Entidad);
            return RedirectToAction("ListarChoferes", "Choferes");
        }
        public async Task<IActionResult> EliminarChoferes(int codempleado)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.EliminarChoferes(new Choferes { CodEmpleado = codempleado });
            return RedirectToAction("ListarChoferes", "Choferes");
        }
        #endregion
    }
}
