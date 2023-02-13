using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedAdrian
{
    internal class Login
    {
        public List<Profile> UserList = new List<Profile>()
        {
            new Profile("Marija", "123"),
            new Profile("Adrian", "456"),
            
        };


        public void LoginProfile()
        {
            
            Console.WriteLine("Enter your username: ");
            
                var userInput = Console.ReadLine();
                var currentUser = UserList.FirstOrDefault(user => user.Name == userInput);
                if (currentUser != null)
                {

                    Console.WriteLine("Enter your password: ");
                    var passwordInput = Console.ReadLine();
                    if (currentUser.UserPassword == passwordInput)
                    {
                        Console.WriteLine("Welcome " + currentUser.Name);
                        var getnetwork = new GetNetwork();                      
                    }
                    else
                    {
                        Console.WriteLine("Fail. Try again!");

                    }
                }          
            
        }

    }
}
