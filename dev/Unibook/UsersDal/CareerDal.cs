using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace UsersDal
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
                careerReturn = (from career in objContex.CareerSet
                                where career.Deleted == false && career.CareerId == id
                                select career).Single<Career>();
            }
            catch (Exception ex)
            {
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
                objContex.CareerSet.Add(career);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
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
                Career career = objContex.CareerSet.Find(id);
                career.Deleted = true;
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
