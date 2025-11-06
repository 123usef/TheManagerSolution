using Microsoft.EntityFrameworkCore;
using TheManager.Context;
using TheManager.Models.Auth;

namespace TheManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();

            Console.WriteLine("please enter your system role : ");
            string UserVal = Console.ReadLine();
            UserRole role = new UserRole();
            //role.Id = 1;
            role.role = UserVal;


            _context.userRoles.Add(role);
            _context.SaveChanges();
            
            var roles = _context.userRoles.ToList();

            foreach (var item in roles)
            {
                Console.WriteLine($" {item.Id} role is   : {item.role}" );
            }
            _context.userRoles.Remove(roles[2]);
            _context.SaveChanges();


            //UserRole role1 = new UserRole();
            //role1.Id = 2;
            //role1.role = "user";

            //User user = new User()
            //{
            //    id = 1,
            //    Name = "joonguini",
            //    Email = "bla bla bla",
            //    Password = "123456789",
            //    UserRoleid = 2

            //};


        }
    }
}
