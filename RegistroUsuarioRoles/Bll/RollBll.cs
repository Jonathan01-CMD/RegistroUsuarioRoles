using System;
using System.Collections.Generic;
using System.Text;
using RegistroUsuarioRoles.Entidades;
using RegistroUsuarioRoles.DAL;
using System.Linq;
using System.Linq.Expressions;

namespace RegistroUsuarioRoles.Bll
{
    class RollBll
    {
        public static bool Guardar(Roll roles)
        {
            if (!Existe(roles.RolliD))
                return Insertar(roles);
            else
                return Modificar(roles);
        }
        private static bool Insertar(Roll roles)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Roll.Add(roles);
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Roll roles)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(roles).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var usuario = contexto.Usuario.Find(id);

                if (usuario != null)
                {
                    contexto.Usuario.Remove(usuario);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Roll Buscar(int id)
        {
            Contexto rolcontexto = new Contexto();
            Roll roles;

            try
            {
                roles = rolcontexto.Roll.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                rolcontexto.Dispose();
            }

            return roles;
        }

        public static bool Existe(int id)
        {
            Contexto roll = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = roll.Roll.Any(e => e.RolliD == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                roll.Dispose();
            }

            return encontrado;
        }
        private static List<Roll> GetList(Expression<Func<Roll, bool>> criterio)
        {
            List<Roll> lista = new List<Roll>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Roll.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
