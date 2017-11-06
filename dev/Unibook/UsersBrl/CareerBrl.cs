using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class CareerBrl
    {
        /// <summary>
        /// Create a new career
        /// </summary>
        /// <param name="career"></param>
        /// <param name="objContex"></param>
        public static void Insertar(CareerDto careerDto, ModelUnibookContainer objContex)
        {
            try
            {
                Career career = new Career();
                career.CareerId = careerDto.CareerId;
                career.Name = careerDto.Name;
                career.Deleted = careerDto.Deleted;
                career.Faculty = FacultyBrl.Get(careerDto.Faculty.FacultyId, objContex);
                CareerDal.Insert(career, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a career with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Career Get(int id, ModelUnibookContainer objContex)
        {
            Career career = null;
            try
            {
                career = CareerDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return career;
        }

        /// <summary>
        /// Get a person with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static CareerDto GetDto(int id, ModelUnibookContainer objContex)
        {
            CareerDto careerDto = null;
            try
            {
                Career career = CareerDal.Get(id, objContex);
                careerDto.CareerId = career.CareerId;
                careerDto.Name = career.Name;
                careerDto.Deleted = career.Deleted;
                careerDto.Faculty = new FacultyDto();
                careerDto.Faculty.FacultyId = career.Faculty.FacultyId;
                careerDto.Faculty.Name = career.Faculty.Name;
                careerDto.Faculty.Deleted = career.Faculty.Deleted;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return careerDto;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="career"></param>
        /// <param name="objContex"></param>
        public static void Update(CareerDto careerDto, ModelUnibookContainer objContex)
        {
            try
            {
                Career career = CareerBrl.Get(careerDto.CareerId, objContex);
                career.Name = careerDto.Name;
                career.Deleted = careerDto.Deleted;
                career.Faculty = FacultyBrl.Get(careerDto.Faculty.FacultyId, objContex);
                CareerDal.Update(career, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete a career
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CareerDal.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
