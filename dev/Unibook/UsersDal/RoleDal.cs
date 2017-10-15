using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace UsersDal
{
    public class RoleDal
    {
        #region metodos

        /// <summary>
        /// Get role by id
        /// </summary>
        /// <param name="id">Id role to search</param>
        /// <returns></returns>
        public static Role Get(int id, ModelUnibookContainer objContex)
        {
            Role roleReturn = null;


            try
            {
                roleReturn = (from role in objContex.RoleSet
                              where role.Deleted == false && role.RoleId == id
                              select role).Single<Role>();
            }
            catch (Exception ex)
            {
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
                objContex.RoleSet.Add(role);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
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
                throw ex;
            }
        }

        /// <summary>
        /// Deleted a role
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                Role role = objContex.RoleSet.Find(id);
                role.Deleted = true;
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion metodos
    }
}
