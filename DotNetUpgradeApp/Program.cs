using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace UpgradingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            // Prompt user for input
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            var userObject = new User(name, email, password);

            // Generate json string based on created user object
            var jsonUtil = new JsonUnil();
            var userJsonString = jsonUtil.GenerateJsonStringFromUserObject(userObject);

            // Show generated json string
            Console.WriteLine(userJsonString);

            Console.ReadLine();
        }
    }
}
