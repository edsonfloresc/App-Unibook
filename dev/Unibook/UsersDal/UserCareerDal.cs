using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace UsersDal
{
    public class UserCareerDal
    {
        #region metodos

        /// <summary>
        /// Get user career by id
        /// </summary>
        /// <param name="id">Id user career to search</param>
        /// <returns></returns>
        public static UserCareer Get(int id, ModelUnibookContainer objContex)
        {
            UserCareer userCareerReturn = null;


            try
            {
                userCareerReturn = (from userCareer in objContex.UserCareerSet
                                    where userCareer.UserCareerId == id
                                    select userCareer).Single<UserCareer>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userCareerReturn;
        }

        /// <summary>
        /// Insert a user Career
        /// </summary>
        /// <param name="userCareer"></param>
        /// <param name="objContex"></param>
        public static void Insert(UserCareer userCareer, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.UserCareerSet.Add(userCareer);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update a user Career
        /// </summary>
        /// <param name="userCareer"></param>
        /// <param name="objContex"></param>
        public static void Update(UserCareer userCareer, ModelUnibookContainer objContex)
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

        #endregion metodos
    }
}
