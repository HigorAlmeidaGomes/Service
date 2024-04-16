using System;
using System.Collections.Generic;

namespace ServiceSearchActions.Core.Entites.Shares
{
    public class Users : BaseEntity
    {
        public Users()
        {
            new List<Users>().Add(this); 
        }

        public Users(string fullName, string email, DateTime birthDate, DateTime createAt, bool active, string password, string role)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            CreateAt = createAt;
            Active = active;
            Password = password;
            Role = role;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public DateTime CreateAt { get; private set; }

        public bool Active { get; private set; }

        public string Password { get; private set; }

        public string Role { get; private set; }
    }
}
