using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class SubjectCareerDal
    {
        #region Methods

        /// <summary>
        /// Get Relation subject to career by id
        /// </summary>
        /// <param name="id">Id realtion subject to career to search</param>
        /// <returns>Return object relation of subject to career</returns>
        public static SubjectCareer Get(int id, ModelUnibookContainer objContex)
        {
            SubjectCareer subjectCareerReturn = null;

            try
            {
                bool exist = (from subjectCareer in objContex.SubjectCareerSet
                              where subjectCareer.SubjectCareerId == id
                              select subjectCareer).Count() > 0;
                if (exist)
                {
                    subjectCareerReturn = (from subjectCareer in objContex.SubjectCareerSet
                                           where subjectCareer.SubjectCareerId == id
                                           select subjectCareer).Single<SubjectCareer>();
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

            return subjectCareerReturn;
        }

        /// <summary>
        /// Insert a relation subject to career
        /// </summary>
        /// <param name="subjectCareer">Object relation subject with career to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(SubjectCareer subjectCareer, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SubjectCareerSet.Add(subjectCareer);
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
        /// Update a relation subject to career
        /// </summary>
        /// <param name="objContex"> Get table to object</param> 
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
