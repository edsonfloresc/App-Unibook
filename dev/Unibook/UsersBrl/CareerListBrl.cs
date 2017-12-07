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
    public class CareerListBrl
    {
        /// <summary>
        /// Get list person 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<CareerDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<CareerDto> careerList = new List<CareerDto>();
                foreach (var item in CareerListDal.Get(objContex))
                {
                    CareerDto career = new CareerDto()
                    {
                        Deleted = item.Deleted,
                        Name = item.Name,
                        CareerId = item.CareerId,
                        Faculty = new FacultyDto() { FacultyId = item.Faculty.FacultyId, Name = item.Faculty.Name, Deleted = item.Faculty.Deleted }
                    };

                    careerList.Add(career);
                }

                return careerList;
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
