using DependencyInjectionSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.Services
{
    public interface IUsersService
    {
        IEnumerable<UserModel> Get();
    }
}
