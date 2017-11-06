using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class FacultyBrl
    {
        /// <summary>
        /// Create a new faculty
        /// </summary>
        /// <param name="faculty"></param>
        /// <param name="objContex"></param>
        public static void Insertar(FacultyDto facultyDto, ModelUnibookContainer objContex)
        {
            try
            {
                Faculty faculty = new Faculty();
                faculty.FacultyId = facultyDto.FacultyId;
                faculty.Name = facultyDto.Name;
                faculty.Deleted = facultyDto.Deleted;
                FacultyDal.Insert(faculty, objContex);
            }
            catch (Exception)
            {


            }
        }

        /// <summary>
        /// Get a faculty with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Faculty Get(int id, ModelUnibookContainer objContex)
        {
            Faculty faculty = null;
            try
            {
                faculty = FacultyDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return faculty;
        }

        /// <summary>
        /// Get a faculty with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static FacultyDto GetDto(int id, ModelUnibookContainer objContex)
        {
            FacultyDto facultyDto = null;
            try
            {
                Faculty faculty = FacultyDal.Get(id, objContex);
                facultyDto = new FacultyDto();
                facultyDto.FacultyId = faculty.FacultyId;
                facultyDto.Name = faculty.Name;
                facultyDto.Deleted = faculty.Deleted;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return facultyDto;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="objContex"></param>
        public static void Update(FacultyDto facultyDto, ModelUnibookContainer objContex)
        {
            try
            {
                Faculty faculty = FacultyBrl.Get(facultyDto.FacultyId, objContex);
                faculty.Name = faculty.Name;
                faculty.Deleted = faculty.Deleted;
                FacultyDal.Update(faculty, objContex);
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
                FacultyDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
