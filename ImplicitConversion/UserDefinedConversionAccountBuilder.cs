using System.Runtime.InteropServices.ComTypes;

namespace ImplicitConversion
{
    public class UserDefinedConversionAccountBuilder
    {
        private string _name;
        private string _password;
        private string _email;
        private int _age;

        public UserDefinedConversionAccountBuilder CreateAccout() => this;

        public UserDefinedConversionAccountBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public UserDefinedConversionAccountBuilder WithPassword(string password)
        {
            _password = password;
            return this;
        }
        public UserDefinedConversionAccountBuilder WithEmail(string email)
        {
            _email = email;
            return this;
        }

        public UserDefinedConversionAccountBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }

        public static implicit operator Account(UserDefinedConversionAccountBuilder builder)
        {
            return new Account(builder._name, builder._password, builder._email, builder._age);

        }
    }
}
