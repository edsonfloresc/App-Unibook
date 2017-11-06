using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class PublicationMatterCareerFacultyDal
    {
        #region Methods

        /// <summary>
        /// Get publication realtions by id
        /// </summary>
        /// <param name="id">Id publication relation to search</param>
        /// <param name="objContex">Get table to object</param>
        /// <returns>Return object publication relations</returns>
        public static PublicationMatterCareerFaculty Get(int id, ModelUnibookContainer objContex)
        {
            PublicationMatterCareerFaculty publicationMatterCareerFacultyReturn = null;
      
            try
            {
                bool exist = (from publicationMatterCareerFaculty in objContex.PublicationMatterCareerFacultySet
                              where publicationMatterCareerFaculty.PublicationMatterCareerFacultyId == id
                              select publicationMatterCareerFaculty).Count() > 0;
                if (exist)
                {
                    publicationMatterCareerFacultyReturn = (from publicationMatterCareerFaculty in objContex.PublicationMatterCareerFacultySet
                                                            where publicationMatterCareerFaculty.PublicationMatterCareerFacultyId == id
                                                            select publicationMatterCareerFaculty).Single<PublicationMatterCareerFaculty>();
                }
               
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return publicationMatterCareerFacultyReturn;
        }

        /// <summary>
        /// Insert a publication relations
        /// </summary>
        /// <param name="publicationMatterCareerFaculty">Object publication relations to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(PublicationMatterCareerFaculty publicationMatterCareerFaculty, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.PublicationMatterCareerFacultySet.Add(publicationMatterCareerFaculty);
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Update a publication relations
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        #endregion 
    }
}
