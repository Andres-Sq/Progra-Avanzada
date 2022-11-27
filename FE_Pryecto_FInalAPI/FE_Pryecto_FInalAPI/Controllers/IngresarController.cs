using FE_Pryecto_FInalAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Controllers
{
    public class IngresarController : Controller
    {
        public IActionResult Ingresar()
        {
            return View();
        }
        public IActionResult AccesoDenegado()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Autenticacion(Usuario _usuario)
        {
            _usuario.Cedula = 0;
            Usuario objusuarios = _usuario.ValidarUsuario();
            if (objusuarios != null || objusuarios.Cedula > 0)
            {
                var claims = new List<Claim>()
                {
                    //new Claim(ClaimTypes.Name, objusuarios.Cedula),
                    //new Claim("Usuario", objusuarios.Cedula)
                };
                //foreach (Perfiles item in objusuarios.Perfiles)
                //{
                //    claims.Add(new Claim(ClaimTypes.Role, item.Perfil.ToString()));
                //}
                var claimidentidad = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimidentidad));
                return RedirectToAction("Home_Users", "HomeUsers");
            }
            return RedirectToAction("Ingresar");
        }
        [HttpGet]
        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Ingresar", "Ingresar");
        }
    }
}
