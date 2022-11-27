using AccesoDatos.Interfaces;
using Entidades.Entidad;
using Negocio.Interfaces;
using System.Collections.Generic;

namespace Negocio
{
    public class NegocioSQL : INegocioSQL
    {
        private readonly IAccesoDatosSQL _accesoDatosSQL;
        public NegocioSQL(IAccesoDatosSQL accesoDatosSQL)
        {
            _accesoDatosSQL = accesoDatosSQL;
        }

        #region Unidades
        public bool AgregarUnidades(Unidades P_Entidad)
        {
            return _accesoDatosSQL.AgregarUnidades(P_Entidad);
        }
        public List<Unidades> ConsultarUnidades(Unidades P_Entidad)
        {
            return _accesoDatosSQL.ConsultarUnidades(P_Entidad);
        }
        public bool ModificarUnidades(Unidades P_Entidad)
        {
            return _accesoDatosSQL.ModificarUnidades(P_Entidad);
        }
        public bool EliminarUnidades(Unidades P_Entidad)
        {
            return _accesoDatosSQL.EliminarUnidades(P_Entidad);
        }
        #endregion

        #region UnidadAsignada
        public bool AgregarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            return _accesoDatosSQL.AgregarUnidadAsignada(P_Entidad);
        }
        public List<UnidadAsignada> ConsultarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            return _accesoDatosSQL.ConsultarUnidadAsignada(P_Entidad);
        }
        public bool ModificarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            return _accesoDatosSQL.ModificarUnidadAsignada(P_Entidad);
        }
        public bool EliminarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            return _accesoDatosSQL.EliminarUnidadAsignada(P_Entidad);
        }
        #endregion

        #region Choferes
        public bool AgregarChoferes(Choferes P_Entidad)
        {
            return _accesoDatosSQL.AgregarChoferes(P_Entidad);
        }
        public List<Choferes> ConsultarChoferes(Choferes P_Entidad)
        {
            return _accesoDatosSQL.ConsultarChoferes(P_Entidad);
        }
        public bool ModificarChoferes(Choferes P_Entidad)
        {
            return _accesoDatosSQL.ModificarChoferes(P_Entidad);
        }
        public bool EliminarChoferes(Choferes P_Entidad)
        {
            return _accesoDatosSQL.EliminarChoferes(P_Entidad);
        }
        #endregion

        #region Ruta
        public bool AgregarRuta(Ruta P_Entidad)
        {
            return _accesoDatosSQL.AgregarRuta(P_Entidad);
        }
        public List<Ruta> ConsultarRuta(Ruta P_Entidad)
        {
            return _accesoDatosSQL.ConsultarRuta(P_Entidad);
        }
        public bool ModificarRuta(Ruta P_Entidad)
        {
            return _accesoDatosSQL.ModificarRuta(P_Entidad);
        }
        public bool EliminarRuta(Ruta P_Entidad)
        {
            return _accesoDatosSQL.EliminarRuta(P_Entidad);
        }
        #endregion

        #region RutaChofer
        public bool AgregarRutaChofer(RutaChofer P_Entidad)
        {
            return _accesoDatosSQL.AgregarRutaChofer(P_Entidad);
        }
        public List<RutaChofer> ConsultarRutaChofer(RutaChofer P_Entidad)
        {
            return _accesoDatosSQL.ConsultarRutaChofer(P_Entidad);
        }
        public bool ModificarRutaChofer(RutaChofer P_Entidad)
        {
            return _accesoDatosSQL.ModificarRutaChofer(P_Entidad);
        }
        public bool EliminarRutaChofer(RutaChofer P_Entidad)
        {
            return _accesoDatosSQL.EliminarRutaChofer(P_Entidad);
        }
        #endregion

        #region Usuario
        public bool AgregarUsuario(Usuario P_Entidad)
        {
            return _accesoDatosSQL.AgregarUsuario(P_Entidad);
        }
        public List<Usuario> ConsultarUsuario(Usuario P_Entidad)
        {
            return _accesoDatosSQL.ConsultarUsuario(P_Entidad);
        }
        public bool EliminarUsuario(Usuario P_Entidad)
        {
            return _accesoDatosSQL.EliminarUsuario(P_Entidad);
        }
        #endregion

        #region PerfilAsignado
        public List<PerfilAsignado> ConsultarPerfilAsignado(PerfilAsignado P_Entidad)
        {
            return _accesoDatosSQL.ConsultarPerfilAsignado(P_Entidad);
        }
        #endregion
    }
}
