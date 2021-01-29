using DependencyInjectionSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.Services
{
    public class UsersService : IUsersService
    {

        private ICollection<UserModel> _users { get; }
        public UsersService()
        {
            _users = new List<UserModel>();
           
            _users.Add(new UserModel("Alfie","Dawe"));
            _users.Add(new UserModel("Lubna", "Goldsmith"));
            _users.Add(new UserModel("Eben", "Hale"));
            _users.Add(new UserModel("Ceri", "Dejesus"));
            _users.Add(new UserModel("Malikah", "Haney"));
            _users.Add(new UserModel("Hadley", "Denton"));
            _users.Add(new UserModel("Samir", "Welsh"));
            _users.Add(new UserModel("Alexia", "York"));
            _users.Add(new UserModel("Stefano", "Hardwood"));
            _users.Add(new UserModel("Oscar", "Hall"));
            _users.Add(new UserModel("Aneesah", "Cummings"));
        }

        public IEnumerable<UserModel> Get()
        {
            return _users;
        }
    }
}
