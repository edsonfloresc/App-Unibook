using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class RoleBrl
    {
        /// <summary>
        /// Create a new role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insert(RoleDto roleDto, ModelUnibookContainer objContex)
        {
            try
            {
                Role role = new Role();
                role.Name = roleDto.Name;
                role.RoleId = roleDto.RoleId;
                role.Deleted = roleDto.Deleted; 
                RoleDal.Insert(role, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a role with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Role Get(short id, ModelUnibookContainer objContex)
        {
            Role role = null;
            try
            {
                role = RoleDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return role;
        }

        /// <summary>
        /// Get a role with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static RoleDto GetDto(short id, ModelUnibookContainer objContex)
        {
            RoleDto roleDto = null;
            try
            {
                Role role = RoleDal.Get(id, objContex);
                roleDto = new RoleDto();
                roleDto.RoleId = role.RoleId;
                roleDto.Name = role.Name;
                roleDto.Deleted = roleDto.Deleted;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return roleDto;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(RoleDto roleDto, ModelUnibookContainer objContex)
        {
            try
            {
                Role role = RoleBrl.Get(roleDto.RoleId, objContex); ;
                role.Name = roleDto.Name;
                role.Deleted = roleDto.Deleted;
                RoleDal.Update(role, objContex);
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
        public static void Delete(short id, ModelUnibookContainer objContex)
        {
            try
            {
                RoleDal.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
