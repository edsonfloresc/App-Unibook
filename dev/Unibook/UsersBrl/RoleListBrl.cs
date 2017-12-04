using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class RoleListBrl
    {
        /// <summary>
        /// Get list gender 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<RoleDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<RoleDto> roleList = new List<RoleDto>();
                foreach (var item in RoleListDal.Get(objContex))
                {
                    RoleDto role = new RoleDto()
                    {
                        Name = item.Name,
                        RoleId = item.RoleId,
                    };

                    roleList.Add(role);
                }

                return roleList;
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
