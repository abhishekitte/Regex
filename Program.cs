using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration user = new UserRegistration();
            user.Validation();
            Console.ReadLine();
        }
    }
}