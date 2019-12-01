using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.User
{
    class User
    {
        public string Username  { get; set; }
        public string Email  { get; set; }
        public string Password  { get; set; }
        public Guid UserGuid { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
    }
}
