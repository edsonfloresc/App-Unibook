using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class UserDto
    {
        public long UserId { get; set; }
        public string Email { get; set; }
        public PasswordDto Password { get; set; }
        public bool Deleted { get; set; }
        public RoleDto Role { get; set; }
        public UserCareerDto UserCareer { get; set; }
        public PersonDto Person { get; set; }
    }
}
