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
    public class SubjectBrl
    {
        #region Methods

        /// <summary>
        /// Insert a subject 
        /// </summary>
        /// <param name="categoryAcademic">Object subject to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(Subject subject, ModelUnibookContainer objContex)
        {
            try
            {
                SubjectDal.Insert(subject, objContex);
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
        /// Get subject by id
        /// </summary>
        /// <param name="id">Id subject to search</param>
        /// <param name="objContex">Get table to object</param>
        /// <returns>Return object subject</returns>
        public static Subject Get(int id, ModelUnibookContainer objContex)
        {
            Subject subject = null;

            try
            {
                subject = SubjectDal.Get(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return subject;
        }

        /// <summary>
        /// Update a subject
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                SubjectDal.Update(objContex);
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
        /// Deleted a subject
        /// </summary>
        /// <param name="id">Id subject to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                SubjectDal.Delete(id, objContex);
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
