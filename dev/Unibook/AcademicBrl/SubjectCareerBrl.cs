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
    public class SubjectCareerBrl
    {
        #region Methods

        /// <summary>
        /// Insert a relation subject to career
        /// </summary>
        /// <param name="subjectCareer">Object relation subject with career to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(SubjectCareer subjectCareer, ModelUnibookContainer objContex)
        {
            try
            {
                SubjectCareerDal.Insert(subjectCareer, objContex);
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
        /// Get Relation subject to career by id
        /// </summary>
        /// <param name="id">Id realtion subject to career to search</param>
        /// <returns>Return object relation of subject to career</returns>
        public static SubjectCareer Get(int id, ModelUnibookContainer objContex)
        {
            SubjectCareer subjectCareer = null;

            try
            {
                subjectCareer = SubjectCareerDal.Get(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return subjectCareer;
        }

        /// <summary>
        /// Update a relation subject to career
        /// </summary>
        /// <param name="objContex"> Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                SubjectCareerDal.Update(objContex);
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
