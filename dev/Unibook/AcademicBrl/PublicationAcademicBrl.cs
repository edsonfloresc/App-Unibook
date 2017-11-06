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
    public class PublicationAcademicBrl
    {
        #region Methods

        /// <summary>
        /// Insert a publication
        /// </summary>
        /// <param name="publicationAcademic">Object publication to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(PublicationAcademicDto publicationAcademicDto, ModelUnibookContainer objContex)
        {
            try
            {
                PublicationAcademic publicationAcademic = new PublicationAcademic();
                publicationAcademic.PublicationAcademicId = publicationAcademicDto.PublicationAcademicId;
                publicationAcademic.Description = publicationAcademicDto.Description;
                publicationAcademic.Image = publicationAcademicDto.Image;
                publicationAcademic.DatePublication = publicationAcademicDto.DatePublication;
                publicationAcademic.Deleted = publicationAcademicDto.Deleted;
                publicationAcademic.CategoryAcademic = CategoryAcademicBrl.Get(publicationAcademicDto.CategoryAcademic.CategoryAcademicId,objContex);
                publicationAcademic.User = UserBrl.Get(publicationAcademicDto.User.UserId,objContex);
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
        /// Get publication by id dto
        /// </summary>
        /// <param name="id">Id publication to search</param>
        /// <returns>Return object publication</returns>
        public static PublicationAcademicDto GetDto(long id, ModelUnibookContainer objContex)
        {
            PublicationAcademicDto publicationAcademicDto = null;

            try
            {
                PublicationAcademic publicationAcademic = PublicationAcademicDal.Get(id, objContex);
                publicationAcademicDto = new PublicationAcademicDto();
                publicationAcademicDto.PublicationAcademicId = publicationAcademic.PublicationAcademicId;
                publicationAcademicDto.Description = publicationAcademic.Description;
                publicationAcademicDto.Image = publicationAcademic.Image;
                publicationAcademicDto.DatePublication = publicationAcademic.DatePublication;
                publicationAcademicDto.Deleted = publicationAcademic.Deleted;
                publicationAcademicDto.CategoryAcademic = CategoryAcademicBrl.GetDto(publicationAcademic.CategoryAcademic.CategoryAcademicId,objContex);
                publicationAcademicDto.User = UserBrl.GetDto(publicationAcademic.User.UserId, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return publicationAcademicDto;
        }

        /// <summary>
        /// Update a publication 
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(PublicationAcademicDto publicationAcademicDto,ModelUnibookContainer objContex)
        {
            try
            {
                PublicationAcademic publicationAcademic = PublicationAcademicDal.Get(publicationAcademicDto.PublicationAcademicId,objContex);
                publicationAcademic.Description = publicationAcademicDto.Description;
                publicationAcademic.Image = publicationAcademicDto.Image;
                publicationAcademic.DatePublication = publicationAcademicDto.DatePublication;
                publicationAcademic.Deleted = publicationAcademicDto.Deleted;
                publicationAcademic.CategoryAcademic = CategoryAcademicBrl.Get(publicationAcademicDto.CategoryAcademic.CategoryAcademicId,objContex);
                publicationAcademic.User = UserBrl.Get(publicationAcademicDto.User.UserId, objContex);
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
