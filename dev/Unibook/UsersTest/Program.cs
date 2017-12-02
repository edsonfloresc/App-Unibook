using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.UsersTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Role
            ServiceRoleReference.WebRoleServiceSoapClient roleClient = new ServiceRoleReference.WebRoleServiceSoapClient();
            ServiceRoleReference.RoleDto roleDto = new ServiceRoleReference.RoleDto();
            roleDto.Deleted = false;
            roleDto.Name = "Estudiante";
            //roleDto.RoleId = 1;
            roleClient.Insert(roleDto);
            //roleClient.GetAsync();

            //Faculty
            ServiceFacultyReference.WebFacultyServiceSoapClient facultyClient = new ServiceFacultyReference.WebFacultyServiceSoapClient();
            ServiceFacultyReference.FacultyDto facultyDto = new ServiceFacultyReference.FacultyDto();
            facultyDto.Deleted = false;
            facultyDto.Name = "Tecnologia";
            facultyClient.Insert(facultyDto);

            //Career
            ServiceCareerReference.WebCareerServiceSoapClient careerClient = new ServiceCareerReference.WebCareerServiceSoapClient();
            ServiceCareerReference.CareerDto careerDto = new ServiceCareerReference.CareerDto();
            careerDto.Deleted = false;
            careerDto.Name = "Sistemas";
            //careerDto.Faculty = facultyClient.Get(1);
            careerClient.Insert(careerDto);

            //User
            ServiceUserReference.WebUserServiceSoapClient userClient = new ServiceUserReference.WebUserServiceSoapClient();
            ServiceUserReference.UserDto userDto = new ServiceUserReference.UserDto();
            userDto.Deleted = false;
            userDto.Email = "roberto@gmail.com";
            userDto.Password = "1234";
            //userDto.Role = roleClient.Get(1);
            userClient.Insert(userDto);
        }
    }
}
