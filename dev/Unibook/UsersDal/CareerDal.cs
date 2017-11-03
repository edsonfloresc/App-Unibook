using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class CareerDal
    {
        #region metodos

        /// <summary>
        /// Get career by id
        /// </summary>
        /// <param name="id">Id career to search</param>
        /// <returns></returns>
        public static Career Get(int id, ModelUnibookContainer objContex)
        {
            Career careerReturn = null;


            try
            {
                careerReturn = (from career in objContex.Career
                                where career.Deleted == false && career.CareerId == id
                                select career).Single<Career>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return careerReturn;
        }

        /// <summary>
        /// Insert a Career
        /// </summary>
        /// <param name="career"></param>
        /// <param name="objContex"></param>
        public static void Insert(Career career, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.Career.Add(career);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Update a career
        /// </summary>
        /// <param name="career"></param>
        /// <param name="objContex"></param>
        public static void Update(Career career, ModelUnibookContainer objContex)
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
        /// Deleted a career
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                Career career = objContex.Career.Find(id);
                career.Deleted = true;
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
