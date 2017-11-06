using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class PublicationAcademicListBrl
    {
        /// <summary>
        /// Get list publication 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<PublicationAcademicDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<PublicationAcademicDto> publicationList = new List<PublicationAcademicDto>();
                foreach (var item in PublicationAcademicListDal.Get(objContex))
                {
                    publicationList.Add(PublicationAcademicBrl.GetDto(item.PublicationAcademicId, objContex));
                }

                return publicationList;
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
    }
}
