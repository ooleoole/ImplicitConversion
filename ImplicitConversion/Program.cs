using System;

namespace ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new UserDefinedConversionAccountBuilder();
            Account account = builder.CreateAccout().WithName("Ola").WithEmail("ola@mail.com").WithPassword("123456")
                .WithAge(32);

            Console.WriteLine(account.Name+" " + account.Age + " " + account.Email + " " + account.Password);
            Console.ReadLine();
        }
    }
}
