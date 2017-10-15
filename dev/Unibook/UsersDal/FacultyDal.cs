using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace UsersDal
{
    public class FacultyDal
    {
        #region metodos

        /// <summary>
        /// Get faculty by id
        /// </summary>
        /// <param name="id">Id faculty to search</param>
        /// <returns></returns>
        public static Faculty Get(int id, ModelUnibookContainer objContex)
        {
            Faculty facultyReturn = null;


            try
            {
                facultyReturn = (from faculty in objContex.FacultySet
                                 where faculty.Deleted == false && faculty.FacultyId == id
                                 select faculty).Single<Faculty>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return facultyReturn;
        }

        /// <summary>
        /// Insert a faculty
        /// </summary>
        /// <param name="faculty"></param>
        /// <param name="objContex"></param>
        public static void Insert(Faculty faculty, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.FacultySet.Add(faculty);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update a Faculy
        /// </summary>
        /// <param name="faculty"></param>
        /// <param name="objContex"></param>
        public static void Update(Faculty faculty, ModelUnibookContainer objContex)
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
        /// Deleted a faculty
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                Faculty faculty = objContex.FacultySet.Find(id);
                faculty.Deleted = true;
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
