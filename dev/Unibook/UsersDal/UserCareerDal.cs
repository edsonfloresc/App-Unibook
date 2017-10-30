using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class UserCareerDal
    {
        #region metodos

        /// <summary>
        /// Get user career by id
        /// </summary>
        /// <param name="id">Id user career to search</param>
        /// <returns></returns>
        public static UserCareer Get(long id, ModelUnibookContainer objContex)
        {
            UserCareer userCareerReturn = null;


            try
            {
                userCareerReturn = (from userCareer in objContex.UserCareer
                                    where userCareer.UserCareerId == id
                                    select userCareer).Single<UserCareer>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
                objContex.UserCareer.Add(userCareer);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        #endregion metodos
    }
}
