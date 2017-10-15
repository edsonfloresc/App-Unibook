using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using UsersDal;

namespace UsersBrl
{
    public class RoleBrl
    {
        /// <summary>
        /// Create a new role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insertar(Role role, ModelUnibookContainer objContex)
        {
            try
            {
                RoleDal.Insert(role, objContex);
            }
            catch (Exception)
            {


            }
        }

        /// <summary>
        /// Get a role with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Role Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return RoleDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(Role role, ModelUnibookContainer objContex)
        {
            try
            {
                RoleDal.Update(role, objContex);
            }
            catch (Exception)
            {

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
                RoleDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
