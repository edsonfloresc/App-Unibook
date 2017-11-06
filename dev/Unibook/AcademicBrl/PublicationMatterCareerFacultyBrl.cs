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
    public class PublicationMatterCareerFacultyBrl
    {
        #region Methods

        /// <summary>
        /// Insert a publication relations
        /// </summary>
        /// <param name="publicationMatterCareerFaculty">Object publication relations to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(PublicationMatterCareerFacultyDto publicationMatterCareerFacultyDto, ModelUnibookContainer objContex)
        {
            try
            {
                PublicationMatterCareerFaculty publicationMatterCareerFaculty = new PublicationMatterCareerFaculty();
                publicationMatterCareerFaculty.PublicationMatterCareerFacultyId = publicationMatterCareerFacultyDto.PublicationMatterCareerFacultyId;
                publicationMatterCareerFaculty.Subject = SubjectBrl.Get(publicationMatterCareerFacultyDto.Subject.SubjectId, objContex);
                publicationMatterCareerFaculty.PublicationAcademic = PublicationAcademicBrl.Get(publicationMatterCareerFacultyDto.PublicationAcademic.PublicationAcademicId,objContex);
                publicationMatterCareerFaculty.Career = CareerBrl.Get(publicationMatterCareerFacultyDto.Career.CareerId, objContex);
                publicationMatterCareerFaculty.Faculty = FacultyBrl.Get(publicationMatterCareerFacultyDto.Faculty.FacultyId,objContex);

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
        /// Get publication realtions by id dto
        /// </summary>
        /// <param name="id">Id publication relation to search</param>
        /// <param name="objContex">Get table to object</param>
        /// <returns>Return object publication relations</returns>
        public static PublicationMatterCareerFacultyDto GetDto(int id, ModelUnibookContainer objContex)
        {
            PublicationMatterCareerFacultyDto publicationMatterCareerFacultyDto = null;

            try
            {
                PublicationMatterCareerFaculty publicationMatterCareerFaculty = PublicationMatterCareerFacultyDal.Get(id, objContex);
                publicationMatterCareerFacultyDto = new PublicationMatterCareerFacultyDto();
                publicationMatterCareerFacultyDto.PublicationMatterCareerFacultyId = publicationMatterCareerFaculty.PublicationMatterCareerFacultyId;
                publicationMatterCareerFacultyDto.PublicationAcademic = PublicationAcademicBrl.GetDto(publicationMatterCareerFaculty.PublicationAcademic.PublicationAcademicId,objContex);
                publicationMatterCareerFacultyDto.Subject = SubjectBrl.GetDto(publicationMatterCareerFaculty.Subject.SubjectId,objContex);
                publicationMatterCareerFacultyDto.Faculty = FacultyBrl.GetDto(publicationMatterCareerFaculty.Faculty.FacultyId,objContex);
                publicationMatterCareerFacultyDto.Career = CareerBrl.GetDto(publicationMatterCareerFaculty.Career.CareerId, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return publicationMatterCareerFacultyDto;
        }

        /// <summary>
        /// Update a publication relations
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(PublicationMatterCareerFacultyDto publicationMatterCareerFacultyDto, ModelUnibookContainer objContex)
        {
            try
            {
                PublicationMatterCareerFaculty publicationMatterCareerFaculty = PublicationMatterCareerFacultyDal.Get(publicationMatterCareerFacultyDto.PublicationMatterCareerFacultyId,objContex);
                publicationMatterCareerFaculty.Subject = SubjectBrl.Get(publicationMatterCareerFacultyDto.Subject.SubjectId, objContex);
                publicationMatterCareerFaculty.PublicationAcademic = PublicationAcademicBrl.Get(publicationMatterCareerFacultyDto.PublicationAcademic.PublicationAcademicId, objContex);
                publicationMatterCareerFaculty.Career = CareerBrl.Get(publicationMatterCareerFacultyDto.Career.CareerId, objContex);
                publicationMatterCareerFaculty.Faculty = FacultyBrl.Get(publicationMatterCareerFacultyDto.Faculty.FacultyId, objContex);

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
