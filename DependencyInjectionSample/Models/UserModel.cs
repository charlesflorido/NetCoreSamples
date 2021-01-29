using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserModel()
        {

        }

        public UserModel(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }
    }
}
