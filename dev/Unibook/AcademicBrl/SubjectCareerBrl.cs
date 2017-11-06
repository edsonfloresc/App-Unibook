using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

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
        public static void Insert(SubjectCareerDto subjectCareerDto, ModelUnibookContainer objContex)
        {
            try
            {
                SubjectCareer subjectCareer = new SubjectCareer();
                subjectCareer.SubjectCareerId = subjectCareerDto.SubjectCareerId;
                subjectCareer.Career = CareerBrl.Get(subjectCareerDto.Career.CareerId, objContex);
                subjectCareer.Subject = SubjectBrl.Get(subjectCareerDto.Subject.SubjectId, objContex);
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
        /// Get Relation subject to career by id dto
        /// </summary>
        /// <param name="id">Id realtion subject to career to search</param>
        /// <returns>Return object relation of subject to career</returns>
        public static SubjectCareerDto GetDto(int id, ModelUnibookContainer objContex)
        {
            SubjectCareerDto subjectCareerDto = null;

            try
            {
                SubjectCareer subjectCareer = SubjectCareerDal.Get(id, objContex);
                subjectCareerDto = new SubjectCareerDto();
                subjectCareerDto.SubjectCareerId = subjectCareer.SubjectCareerId;
                subjectCareerDto.Career = CareerBrl.GetDto(subjectCareer.Career.CareerId,objContex);
                subjectCareerDto.Subject = SubjectBrl.GetDto(subjectCareer.Subject.SubjectId, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return subjectCareerDto;
        }

        /// <summary>
        /// Update a relation subject to career
        /// </summary>
        /// <param name="objContex"> Get table to object</param> 
        public static void Update(SubjectCareerDto subjectCareerDto,ModelUnibookContainer objContex)
        {
            try
            {
                SubjectCareer subjectCareer = SubjectCareerDal.Get(subjectCareerDto.SubjectCareerId,objContex);
                subjectCareer.Career = CareerBrl.Get(subjectCareerDto.Career.CareerId, objContex);
                subjectCareer.Subject = SubjectBrl.Get(subjectCareerDto.Subject.SubjectId, objContex);
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
