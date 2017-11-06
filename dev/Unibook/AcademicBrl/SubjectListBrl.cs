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
    public class SubjectListBrl
    {
        /// <summary>
        /// Get list subject
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<SubjectDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<SubjectDto> subjectList = new List<SubjectDto>();
                foreach (var item in SubjectListDal.Get(objContex))
                {
                    subjectList.Add(SubjectBrl.GetDto(item.SubjectId, objContex));
                }

                return subjectList;
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
