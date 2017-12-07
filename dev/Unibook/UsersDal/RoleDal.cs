using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class RoleDal
    {
        #region metodos

        /// <summary>
        /// Get role by id
        /// </summary>
        /// <param name="id">Id role to search</param>
        /// <returns></returns>
        public static Role Get(short id, ModelUnibookContainer objContex)
        {
            Role roleReturn = null;


            try
            {
                roleReturn = (from role in objContex.Role
                              where role.Deleted == false && role.RoleId == id
                              select role).Single<Role>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return roleReturn;
        }

        /// <summary>
        /// Insert a role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insert(Role role, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.Role.Add(role);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Update a role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(Role role, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Deleted a role
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(short id, ModelUnibookContainer objContex)
        {
            try
            {
                Role role = objContex.Role.Find(id);
                role.Deleted = true;
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Get list role
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<Role> GetAll(ModelUnibookContainer objContex)
        {
            List<Role> rolesReturn = null;

            try
            {
                rolesReturn = (from role in objContex.Role
                               select role).ToList<Role>();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return rolesReturn;
        }

        #endregion metodos
    }
}
