using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheManager.Models.Auth;

namespace TheManager.Context
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            /*
             Data Source(server)=.;
            initial catalog(database) = 
            Integrated Security=True;
            Connect Timeout=30;
            Encrypt=True;
            Trust Server Certificate=True;
             */
            string con = "server = . ; database = themanagerDb;Integrated Security=True; Connect Timeout=30;Encrypt=True;Trust Server Certificate=True; ";
            optionsBuilder.UseSqlServer(con);
        }



        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<User> users { get; set; }



    }
}
