using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitConversion
{
    public class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Account(string name, string password, string email, int age)
        {
            Name = name;
            Password = password;
            Email = email;
            Age = age;
        }
    }
}
