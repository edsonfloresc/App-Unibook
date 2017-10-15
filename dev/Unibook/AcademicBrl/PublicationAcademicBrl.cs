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
    public class PublicationAcademicBrl
    {
        #region Methods

        /// <summary>
        /// Insert a publication
        /// </summary>
        /// <param name="publicationAcademic">Object publication to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(PublicationAcademic publicationAcademic, ModelUnibookContainer objContex)
        {
            try
            {
                PublicationAcademicDal.Insert(publicationAcademic, objContex);
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
        /// Get publication by id
        /// </summary>
        /// <param name="id">Id publication to search</param>
        /// <returns>Return object publication</returns>
        public static PublicationAcademic Get(long id, ModelUnibookContainer objContex)
        {
            PublicationAcademic publicationAcademic = null;

            try
            {
                publicationAcademic = PublicationAcademicDal.Get(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return publicationAcademic;
        }

        /// <summary>
        /// Update a publication 
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                PublicationAcademicDal.Update(objContex);
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
        /// Deleted a publication
        /// </summary>
        /// <param name="id">Id publication to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(long id, ModelUnibookContainer objContex)
        {
            try
            {
                PublicationAcademicDal.Delete(id, objContex);
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
