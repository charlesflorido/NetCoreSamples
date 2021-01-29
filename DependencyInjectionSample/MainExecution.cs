using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

using DependencyInjectionSample.Services;

namespace DependencyInjectionSample
{
    public class MainExecution : IExecution
    {
        private UserCredential _userCredentials;
        private IUsersService _usersService;
        public MainExecution(IOptions<UserCredential> credentials, IUsersService usersService)
        {
            _userCredentials = credentials.Value;
            _usersService = usersService;
        }

        public void Execute()
        {
            Console.WriteLine($"Username: {_userCredentials.Username}");
            Console.WriteLine($"Password: {_userCredentials.Password}");
            Console.WriteLine();
            Console.WriteLine("=============================================");
            int i = 1;
            foreach(var user in _usersService.Get())
            {
                Console.WriteLine($"    1. {user.FirstName} {user.LastName}");
            }

            Console.Write("\n\n\nPress [Enter] to exit: ");
            Console.ReadLine();
        }
    }
}
