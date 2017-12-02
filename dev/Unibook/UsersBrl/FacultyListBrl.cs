using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class FacultyListBrl
    {
        /// <summary>
        /// Get list person 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<FacultyDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<FacultyDto> facultyList = new List<FacultyDto>();
                foreach (var item in FacultyListDal.Get(objContex))
                {
                    FacultyDto faculty = new FacultyDto()
                    {
                        Deleted = item.Deleted,
                        Name = item.Name,
                        FacultyId = item.FacultyId
                    };

                    facultyList.Add(faculty);
                }

                return facultyList;
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
