using System;
using System.Linq;
using System.Collections.Generic;
using Entidades.Entidad;
using AccesoDatos.Interfaces;

namespace AccesoDatos
{
    public class AccesoDatosSQL : IAccesoDatosSQL
    {
        private string sMsjError;

        #region Unidades CRUD
        public bool AgregarUnidades(Unidades P_Entidad)
        {
            using (var contexto = new GestionTransporteContext())
            {
                contexto.Unidades.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }
        public List<Unidades> ConsultarUnidades(Unidades P_Entidad)
        {
            List<Unidades> lstunidades = new List<Unidades>();
            if (P_Entidad != null && P_Entidad.Estado.Length > 0)
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.Unidades
                                     where reg.Estado.Equals(P_Entidad.Estado)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Unidades r = new Unidades
                            {
                                Id = item.Id,
                                Estado = item.Estado,
                                Placa = item.Placa
                            };
                            lstunidades.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.Unidades
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Unidades r = new Unidades
                            {
                                Id = item.Id,
                                Estado = item.Estado,
                                Placa = item.Placa
                            };
                            lstunidades.Add(r);
                        }
                    }
                }
            }
            return lstunidades;
        }
        public bool ModificarUnidades(Unidades P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var consulta = (from reg in contexto.Unidades
                                    where reg.Id.Equals(P_Entidad.Id)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Estado = P_Entidad.Estado;
                        consulta.Placa = P_Entidad.Placa;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        public bool EliminarUnidades(Unidades P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    contexto.Unidades.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region Unidad Asignada CRUD
        public bool AgregarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    contexto.UnidadAsignada.Add(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        public List<UnidadAsignada> ConsultarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            List<UnidadAsignada> lstunidadesasignadas = new List<UnidadAsignada>();
            if (P_Entidad != null && P_Entidad.CodEmpleado > 0)
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.UnidadAsignada
                                     where reg.CodEmpleado.Equals(P_Entidad.CodEmpleado)
                                     select reg).ToList();

                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            UnidadAsignada r = new UnidadAsignada
                            {
                                Id = item.Id,
                                CodEmpleado = item.CodEmpleado,
                                Placa = item.Placa
                            };

                            lstunidadesasignadas.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.UnidadAsignada
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            UnidadAsignada r = new UnidadAsignada
                            {
                                Id = item.Id,
                                CodEmpleado = item.CodEmpleado,
                                Placa = item.Placa
                            };
                            lstunidadesasignadas.Add(r);
                        }
                    }
                }
            }
            return lstunidadesasignadas;
        }
        public bool ModificarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var consulta = (from reg in contexto.UnidadAsignada
                                    where reg.Id.Equals(P_Entidad.Id)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.CodEmpleado = P_Entidad.CodEmpleado;
                        consulta.Placa = P_Entidad.Placa;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        public bool EliminarUnidadAsignada(UnidadAsignada P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    contexto.UnidadAsignada.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region Choferes CRUD
        public bool AgregarChoferes(Choferes P_Entidad)
        {
            using (var contexto = new GestionTransporteContext())
            {
                contexto.Choferes.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }
        public List<Choferes> ConsultarChoferes(Choferes P_Entidad)
        {
            List<Choferes> lstchoferes = new List<Choferes>();
            if (P_Entidad != null && P_Entidad.CodEmpleado > 0)
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.Choferes
                                     where reg.CodEmpleado.Equals(P_Entidad.CodEmpleado)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Choferes r = new Choferes
                            {
                                Id = item.Id,
                                CodEmpleado = item.CodEmpleado,
                                Nombre = item.Nombre,
                                Apellido = item.Apellido,
                                ExpLicencia = item.ExpLicencia
                            };
                            lstchoferes.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.Choferes
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Choferes r = new Choferes
                            {
                                Id = item.Id,
                                CodEmpleado = item.CodEmpleado,
                                Nombre = item.Nombre,
                                Apellido = item.Apellido,
                                ExpLicencia = item.ExpLicencia
                            };
                            lstchoferes.Add(r);
                        }
                    }
                }
            }
            return lstchoferes;
        }
        public bool ModificarChoferes(Choferes P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var consulta = (from reg in contexto.Choferes
                                    where reg.CodEmpleado.Equals(P_Entidad.CodEmpleado)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Nombre = P_Entidad.Nombre;
                        consulta.Apellido = P_Entidad.Apellido;
                        consulta.ExpLicencia = P_Entidad.ExpLicencia;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        public bool EliminarChoferes(Choferes P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    contexto.Choferes.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region Ruta
        public bool AgregarRuta(Ruta P_Entidad)
        {
            using (var contexto = new GestionTransporteContext())
            {
                contexto.Ruta.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }
        public List<Ruta> ConsultarRuta(Ruta P_Entidad)
        {
            List<Ruta> lstruta = new List<Ruta>();
            if (P_Entidad != null && P_Entidad.Id > 0)
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.Ruta
                                     where reg.Id.Equals(P_Entidad.Id)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Ruta r = new Ruta
                            {
                                Id = item.Id,
                                NombreRuta = item.NombreRuta,
                                CantidadParadas = item.CantidadParadas,
                                MontoPasaje = item.MontoPasaje
                            };
                            lstruta.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.Ruta
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Ruta r = new Ruta
                            {
                                Id = item.Id,
                                NombreRuta = item.NombreRuta,
                                CantidadParadas = item.CantidadParadas,
                                MontoPasaje = item.MontoPasaje
                            };
                            lstruta.Add(r);
                        }
                    }
                }
            }
            return lstruta;
        }
        public bool ModificarRuta(Ruta P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var consulta = (from reg in contexto.Ruta
                                    where reg.Id.Equals(P_Entidad.Id)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.NombreRuta = P_Entidad.NombreRuta;
                        consulta.CantidadParadas = P_Entidad.CantidadParadas;
                        consulta.MontoPasaje = P_Entidad.MontoPasaje;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        public bool EliminarRuta(Ruta P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    contexto.Ruta.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region RutaChofer
        public bool AgregarRutaChofer(RutaChofer P_Entidad)
        {
            using (var contexto = new GestionTransporteContext())
            {
                contexto.RutaChofer.Add(P_Entidad);
                P_Entidad.Total = P_Entidad.MontoPasaje*P_Entidad.CantidadPasajeros;
                contexto.SaveChanges();
                return true;
            }
        }
        public List<RutaChofer> ConsultarRutaChofer(RutaChofer P_Entidad)
        {
            List<RutaChofer> lstrutachofer = new List<RutaChofer>();
            if (P_Entidad != null && P_Entidad.CodEmpleado > 0)
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.RutaChofer
                                     where reg.CodEmpleado.Equals(P_Entidad.CodEmpleado)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            RutaChofer r = new RutaChofer
                            {
                                Id = item.Id,
                                CodEmpleado = item.CodEmpleado,
                                NombreRuta = item.NombreRuta,
                                CantidadPasajeros = item.CantidadPasajeros,
                                MontoPasaje = item.MontoPasaje,
                                Total = item.Total+ item.MontoPasaje,
                            };
                            lstrutachofer.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.RutaChofer
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            RutaChofer r = new RutaChofer
                            {
                                Id = item.Id,
                                CodEmpleado = item.CodEmpleado,
                                NombreRuta = item.NombreRuta,
                                CantidadPasajeros = item.CantidadPasajeros,
                                MontoPasaje = item.MontoPasaje,
                                Total = item.Total
                            };
                            lstrutachofer.Add(r);
                        }
                    }
                }
            }
            return lstrutachofer;
        }
        public bool ModificarRutaChofer(RutaChofer P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var consulta = (from reg in contexto.RutaChofer
                                    where reg.Id.Equals(P_Entidad.Id)
                                    select reg).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.CodEmpleado = P_Entidad.CodEmpleado;
                        consulta.NombreRuta = P_Entidad.NombreRuta;
                        consulta.CantidadPasajeros = P_Entidad.CantidadPasajeros;
                        consulta.MontoPasaje = P_Entidad.MontoPasaje;
                        consulta.Total = P_Entidad.CantidadPasajeros * P_Entidad.MontoPasaje;
                        contexto.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        public bool EliminarRutaChofer(RutaChofer P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    contexto.RutaChofer.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region Usuario CRUD
        public bool AgregarUsuario(Usuario P_Entidad)
        {
            using (var contexto = new GestionTransporteContext())
            {
                contexto.Usuario.Add(P_Entidad);
                contexto.SaveChanges();
                return true;
            }
        }
        public List<Usuario> ConsultarUsuario(Usuario P_Entidad)
        {
            List<Usuario> lstusuario = new List<Usuario>();
            if (P_Entidad != null && P_Entidad.Cedula > 0)
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.Usuario
                                     where reg.Cedula.Equals(P_Entidad.Cedula)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Usuario r = new Usuario
                            {
                                Id = item.Id,
                                Cedula = item.Cedula,
                                Clave = item.Clave,
                                Perfil = item.Perfil
                            };
                            lstusuario.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.Usuario
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            Usuario r = new Usuario
                            {
                                Id = item.Id,
                                Cedula = item.Cedula,
                                Clave = item.Clave,
                                Perfil = item.Perfil
                            };
                            lstusuario.Add(r);
                        }
                    }
                }
            }
            return lstusuario;
        }
        public bool EliminarUsuario(Usuario P_Entidad)
        {
            try
            {
                using (var contexto = new GestionTransporteContext())
                {
                    contexto.Usuario.Remove(P_Entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region PerfilAsignado
        public List<PerfilAsignado> ConsultarPerfilAsignado(PerfilAsignado P_Entidad)
        {
            List<PerfilAsignado> lstusuario = new List<PerfilAsignado>();
            if (P_Entidad != null && P_Entidad.Perfil > 0)
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.PerfilAsignado
                                     where reg.Perfil.Equals(P_Entidad.Perfil)
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            PerfilAsignado r = new PerfilAsignado
                            {
                                Perfil = item.Perfil,
                                Tipo = item.Tipo,
                            };
                            lstusuario.Add(r);
                        }
                    }
                }
            }
            else
            {
                using (var contexto = new GestionTransporteContext())
                {
                    var coleccion = (from reg in contexto.PerfilAsignado
                                     select reg).ToList();
                    if (coleccion != null)
                    {
                        foreach (var item in coleccion)
                        {
                            PerfilAsignado r = new PerfilAsignado
                            {
                                Perfil = item.Perfil,
                                Tipo = item.Tipo,
                            };
                            lstusuario.Add(r);
                        }
                    }
                }
            }
            return lstusuario;
        }
        #endregion
    }
}
