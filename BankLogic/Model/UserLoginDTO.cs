using System;
using System.Collections.Generic;
using System.Text;

namespace BankLogic.Model
{
    public class UserLoginDTO
    {
        public string UserId { get; set; }
        public string PasswordUnhashed { get; set; }
        public string PasswordHashed { get; set; }
    }
}
