using Newtonsoft.Json;
using FE_Pryecto_FInalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FE_Pryecto_FInalAPI.Controllers
{
    public class ConexionAPI
    {
        #region Propiedad
        public HttpClient ClienteConexion { get; set; }
        #endregion

        #region Constructor
        public ConexionAPI()
        {
            ClienteConexion = new HttpClient();
            EstablecerParametrosBase();
        }
        #endregion

        #region Metodos

        #region Privados
        private void EstablecerParametrosBase()
        {
            ClienteConexion.BaseAddress = new Uri("http://localhost:31112/");
            ClienteConexion.DefaultRequestHeaders.Accept.Clear();
            ClienteConexion.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion

        #region Publicos

        #region Unidades
        public async Task<bool> AgregarUnidades(Unidades P_Entidad)
        {
            string rutaApi = "api/Unidades/AgregarUnidades";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<List<Unidades>> ConsultarUnidades(Unidades P_Entidad)
        {
            List<Unidades> lstresultado = new List<Unidades>();
            string rutaApi = "api/Unidades/ConsultarUnidades";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonstring = await resultadoConsumo.Content.ReadAsStringAsync();
                lstresultado = JsonConvert.DeserializeObject<List<Unidades>>(jsonstring);
            }
            return lstresultado;
        }
        public async Task<bool> ModificarUnidades(Unidades P_Entidad)
        {
            string rutaApi = "api/Unidades/ModificarUnidades";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<bool> EliminarUnidades(Unidades P_Entidad)
        {
            string rutaApi = "api/Unidades/EliminarUnidades";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

        #region UnidadAsignada
        public async Task<bool> AgregarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            string rutaApi = "api/UnidadAsignada/AgregarUnidadAsignada";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<List<UnidadAsignada>> ConsultarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            List<UnidadAsignada> lstresultado = new List<UnidadAsignada>();
            string rutaApi = "api/UnidadAsignada/ConsultarUnidadAsignada";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonstring = await resultadoConsumo.Content.ReadAsStringAsync();
                lstresultado = JsonConvert.DeserializeObject<List<UnidadAsignada>>(jsonstring);
            }
            return lstresultado;
        }
        public async Task<bool> ModificarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            string rutaApi = "api/UnidadAsignada/ModificarUnidadAsignada";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<bool> EliminarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            string rutaApi = "api/UnidadAsignada/EliminarUnidadAsignada";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

        #region Choferes
        public async Task<bool> AgregarChoferes(Choferes P_Entidad)
        {
            string rutaApi = "api/Choferes/AgregarChoferes";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<List<Choferes>> ConsultarChoferes(Choferes P_Entidad)
        {
            List<Choferes> lstresultado = new List<Choferes>();
            string rutaApi = "api/Choferes/ConsultarChoferes";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonstring = await resultadoConsumo.Content.ReadAsStringAsync();
                lstresultado = JsonConvert.DeserializeObject<List<Choferes>>(jsonstring);
            }
            return lstresultado;
        }
        public async Task<bool> ModificarChoferes(Choferes P_Entidad)
        {
            string rutaApi = "api/Choferes/ModificarChoferes";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<bool> EliminarChoferes(Choferes P_Entidad)
        {
            string rutaApi = "api/Choferes/EliminarChoferes";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

        #region Ruta
        public async Task<bool> AgregarRuta(Ruta P_Entidad)
        {
            string rutaApi = "api/Ruta/AgregarRuta";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<List<Ruta>> ConsultarRuta(Ruta P_Entidad)
        {
            List<Ruta> lstresultado = new List<Ruta>();
            string rutaApi = "api/Ruta/ConsultarRuta";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonstring = await resultadoConsumo.Content.ReadAsStringAsync();
                lstresultado = JsonConvert.DeserializeObject<List<Ruta>>(jsonstring);
            }
            return lstresultado;
        }
        public async Task<bool> ModificarRuta(Ruta P_Entidad)
        {
            string rutaApi = "api/Ruta/ModificarRuta";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<bool> EliminarRuta(Ruta P_Entidad)
        {
            string rutaApi = "api/Ruta/EliminarRuta";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

        #region RutaChofer
        public async Task<bool> AgregarRutaChofer(RutaChofer P_Entidad)
        {
            string rutaApi = "api/RutaChofer/AgregarRutaChofer";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<List<RutaChofer>> ConsultarRutaChofer(RutaChofer P_Entidad)
        {
            List<RutaChofer> lstresultado = new List<RutaChofer>();
            string rutaApi = "api/RutaChofer/ConsultarRutaChofer";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonstring = await resultadoConsumo.Content.ReadAsStringAsync();
                lstresultado = JsonConvert.DeserializeObject<List<RutaChofer>>(jsonstring);
            }
            return lstresultado;
        }
        public async Task<bool> ModificarRutaChofer(RutaChofer P_Entidad)
        {
            string rutaApi = "api/RutaChofer/ModificarRutaChofer";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<bool> EliminarRutaChofer(RutaChofer P_Entidad)
        {
            string rutaApi = "api/RutaChofer/EliminarRutaChofer";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

        #region Usuario
        public async Task<bool> AgregarUsuario(Usuario P_Entidad)
        {
            string rutaApi = "api/Usuario/AgregarUsuario";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        public async Task<List<Usuario>> ConsultarUsuario(Usuario P_Entidad)
        {
            List<Usuario> lstresultado = new List<Usuario>();
            string rutaApi = "api/Usuario/ConsultarUsuario";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonstring = await resultadoConsumo.Content.ReadAsStringAsync();
                lstresultado = JsonConvert.DeserializeObject<List<Usuario>>(jsonstring);
            }
            return lstresultado;
        }
        public async Task<bool> EliminarUsuario(Usuario P_Entidad)
        {
            string rutaApi = "api/Usuario/EliminarUsuario";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            return resultadoConsumo.IsSuccessStatusCode;
        }
        #endregion

        #region PerfilAsignado
        public async Task<List<PerfilAsignado>> ConsultarPerfilAsignado(PerfilAsignado P_Entidad)
        {
            List<PerfilAsignado> lstresultado = new List<PerfilAsignado>();
            string rutaApi = "api/PerfilAsignado/ConsultarPerfilAsignado";
            HttpResponseMessage resultadoConsumo = await ClienteConexion.PostAsJsonAsync(rutaApi, P_Entidad);
            if (resultadoConsumo.IsSuccessStatusCode)
            {
                string jsonstring = await resultadoConsumo.Content.ReadAsStringAsync();
                lstresultado = JsonConvert.DeserializeObject<List<PerfilAsignado>>(jsonstring);
            }
            return lstresultado;
        }
        #endregion

        #endregion

        #endregion
    }
}
