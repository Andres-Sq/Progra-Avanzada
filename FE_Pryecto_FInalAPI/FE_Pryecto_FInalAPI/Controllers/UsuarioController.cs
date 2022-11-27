using FE_Pryecto_FInalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Controllers
{
    public class UsuarioController : Controller
    {
        #region Vista y Carga de datos
        public async Task<IActionResult> ListarUsuario()
        {
            ConexionAPI objconexion = new ConexionAPI();
            List<Usuario> lstusuario = await objconexion.ConsultarUsuario(new Usuario());
            return View(lstusuario);
        }
        public IActionResult AbrirNuevoUsuario()
        {
            return View();
        }
        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> AgregarUsuario(Usuario P_Entidad)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.AgregarUsuario(P_Entidad);
            return RedirectToAction("ListarUsuario", "Usuario");
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarUsuario(int perfil)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.ConsultarUsuario(new Usuario { Perfil = perfil });
            return View();
        }
        public async Task<IActionResult> EliminarUsuario(int cedula)
        {
            ConexionAPI objconexion = new ConexionAPI();
            await objconexion.EliminarUsuario(new Usuario { Cedula = cedula });
            return RedirectToAction("ListarUsuario", "Usuario");
        }
        #endregion
    }
}
