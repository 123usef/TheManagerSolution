using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TheManager.Models.Enums;

namespace TheManager.Models.Auth
{
    public  class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Plan Plan { get; set; } = Plan.free;

        [ForeignKey(nameof(userRole))]
        public int UserRoleid { get; set; }
        
        public UserRole userRole { get; set; }

    }
}
