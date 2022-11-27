using Entidades.Entidad;
using System.Collections.Generic;

namespace AccesoDatos.Interfaces
{
    public interface IAccesoDatosSQL
    {
        #region Interfaces Unidades
        bool AgregarUnidades(Unidades P_Entidad);
        List<Unidades> ConsultarUnidades(Unidades P_Entidad);
        bool ModificarUnidades(Unidades P_Entidad);
        bool EliminarUnidades(Unidades P_Entidad);
        #endregion

        #region Interfaces UnidadAsignada
        bool AgregarUnidadAsignada(UnidadAsignada P_Entidad);
        List<UnidadAsignada> ConsultarUnidadAsignada(UnidadAsignada P_Entidad);
        bool ModificarUnidadAsignada(UnidadAsignada P_Entidad);
        bool EliminarUnidadAsignada(UnidadAsignada P_Entidad);
        #endregion

        #region Interfaces Choferes
        bool AgregarChoferes(Choferes P_Entidad);
        List<Choferes> ConsultarChoferes(Choferes P_Entidad);
        bool ModificarChoferes(Choferes P_Entidad);
        bool EliminarChoferes(Choferes P_Entidad);
        #endregion

        #region Interfaces Ruta
        bool AgregarRuta(Ruta P_Entidad);
        List<Ruta> ConsultarRuta(Ruta P_Entidad);
        bool ModificarRuta(Ruta P_Entidad);
        bool EliminarRuta(Ruta P_Entidad);
        #endregion

        #region Interfaces RutaChofer
        bool AgregarRutaChofer(RutaChofer P_Entidad);
        List<RutaChofer> ConsultarRutaChofer(RutaChofer P_Entidad);
        bool ModificarRutaChofer(RutaChofer P_Entidad);
        bool EliminarRutaChofer(RutaChofer P_Entidad);
        #endregion

        #region Interfaces Usuario
        bool AgregarUsuario(Usuario P_Entidad);
        List<Usuario> ConsultarUsuario(Usuario P_Entidad);
        bool EliminarUsuario(Usuario P_Entidad);
        #endregion

        #region Interfaces PerfilAsignado
        List<PerfilAsignado> ConsultarPerfilAsignado(PerfilAsignado P_Entidad);
        #endregion
    }
}
