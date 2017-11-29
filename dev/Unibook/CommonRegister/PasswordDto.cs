using System;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class PasswordDto
    {
        public int Id { get; set; }

        public string Psw { get; set; }

        public DateTime Date { get; set; }

        public byte State { get; set; }

        public string NewPassword { get; set; }

        public int UserId { get; set; }
    }
}