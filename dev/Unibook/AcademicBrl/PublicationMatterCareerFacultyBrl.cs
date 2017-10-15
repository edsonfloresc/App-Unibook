using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class PublicationMatterCareerFacultyBrl
    {
        #region Methods

        /// <summary>
        /// Insert a publication relations
        /// </summary>
        /// <param name="publicationMatterCareerFaculty">Object publication relations to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(PublicationMatterCareerFaculty publicationMatterCareerFaculty, ModelUnibookContainer objContex)
        {
            try
            {
                PublicationMatterCareerFacultyDal.Insert(publicationMatterCareerFaculty, objContex);
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

        /// <summary>
        /// Get publication realtions by id
        /// </summary>
        /// <param name="id">Id publication relation to search</param>
        /// <param name="objContex">Get table to object</param>
        /// <returns>Return object publication relations</returns>
        public static PublicationMatterCareerFaculty Get(int id, ModelUnibookContainer objContex)
        {
            PublicationMatterCareerFaculty publicationMatterCareerFaculty = null;

            try
            {
                publicationMatterCareerFaculty = PublicationMatterCareerFacultyDal.Get(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return publicationMatterCareerFaculty;
        }

        /// <summary>
        /// Update a publication relations
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                PublicationMatterCareerFacultyDal.Update(objContex);
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

        #endregion
    }
}
