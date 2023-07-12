using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace UpgradingApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Prompt for user's desire action
            Console.WriteLine("Choose action");
            Console.WriteLine("1. Create new user");
            Console.WriteLine("2. Get user by name");
            Console.WriteLine("3. Get all users in database");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                await CreateNewUser();
            }

            if (userChoice == "2")
            {
                await GetUserByName();
            }

            if (userChoice == "3")
            {
                await GetAllUsers();
            }

            Console.ReadLine();
        }

        private static async Task CreateNewUser()
        {
            // Prompt user for input
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your gender");
            string gender = Console.ReadLine();

            var userObject = new User
            {
                NAME = name,
                EMAIL = email,
                GENDER = gender,
            };

            // Try saving user to the database
            var userUtil = new UserUtil();
            await userUtil.CreateNewUser(userObject);

            ShowUser(userObject);
        }

        private static async Task GetUserByName()
        {
            // Prompt user for input
            Console.WriteLine("Enter name that you want to search for");
            string nameToSearch = Console.ReadLine();

            // Try looking for user base on name
            var userUtil = new UserUtil();
            var foundUser = await userUtil.GetSingleUserByName(nameToSearch);

            ShowUser(foundUser);
        }

        private static async Task GetAllUsers()
        {
            var userUtil = new UserUtil();
            var users = await userUtil.GetAllUsersInDatabase();

            foreach(var user in users)
            {
                ShowUser(user);
            }
        }

        private static void ShowUser(User userObject)
        {
            // Generate json string based on created user object
            var jsonUtil = new JsonUnil();
            var userJsonString = jsonUtil.GenerateJsonStringFromUserObject(userObject);

            // Show generated json string
            Console.WriteLine(userJsonString);
        }
    }
}
