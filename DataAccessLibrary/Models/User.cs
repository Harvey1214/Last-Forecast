using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void Encrypt()
        {
            Password = Security.Encrypt(Password);
        }

        public void Decrypt()
        {
            Email = Security.Encrypt(Email);
        }
    }
}
