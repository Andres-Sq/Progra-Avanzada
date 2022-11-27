using Microsoft.AspNetCore.Mvc;
using FE_Pryecto_FInalAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FE_Pryecto_FInalAPI.Controllers
{
    public class UnidadesController : Controller
    {
        #region Vista y Carga de datos
        public async Task<IActionResult> ListarUnidades()
        {
            ConexionAPI objconexion = new ConexionAPI();
            List<Unidades> lstunidades = await objconexion.ConsultarUnidades(new Unidades());
            return View(lstunidades);
        }
        public IActionResult AbrirAgregarUnidades()
        {
            return View();
        }
        public IActionResult AbrirModificarUnidades(int Id, string Estado, string Placa)
        {
            Unidades objunidades = new Unidades
            {
                Id = Id,
                Estado = Estado,
                Placa = Placa
            };
            return View(objunidades);
        }
        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> AgregarUnidades(Unidades P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.AgregarUnidades(P_Entidad);
            return RedirectToAction("ListarUnidades" , "Unidades");
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarUnidades(string estado)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ConsultarUnidades(new Unidades { Estado = estado });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModificarUnidades(Unidades P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ModificarUnidades(P_Entidad);
            return RedirectToAction("ListarUnidades", "Unidades");
        }
        
        public async Task<IActionResult> EliminarUnidades(string placa)
        {
                ConexionAPI objconexion = new ConexionAPI();
                await objconexion.EliminarUnidades(new Unidades { Placa = placa });
                return RedirectToAction("ListarUnidades", "Unidades");
        }

        #endregion
    }
}
