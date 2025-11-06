using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheManager.Models.Auth
{
    public class UserRole
    {
        public int? Id { get; set; }
        public string role { get; set; } // role :user,admin

        public ICollection<User> users { get; set; }=new List<User>();
    }
}
