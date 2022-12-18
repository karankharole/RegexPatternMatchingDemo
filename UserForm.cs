using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegexPatternMatchingDemo
{
    internal class UserForm
    {

        
        public static void userPassword()
        {
            Console.WriteLine("Enter Password  : ");
            string password = Console.ReadLine();

            Regex userPassword = new Regex(@"^[a-z A-Z]{8}");

            bool userPasswordResult = userPassword.IsMatch(password);
            if (userPasswordResult)
            {
                Console.WriteLine($"Valid Password : {password}");
            }
            else
            {
                Console.WriteLine($"Invalide Password : {password}");
            }

        }
    }
}
    

