using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedAdrian
{
    internal class GetNetwork
    {
        public List<Profile> ListOfUsers { get; set; }
        public Profile loggedInProfile; 

        public GetNetwork()
        {

            loggedInProfile = new Profile("0", "Bjørnar", "Tønsberg");

            ListOfUsers = new List<Profile>
            {
                new Profile("1", "Adrian", "Tønsberg"),
                new Profile("2", "Marija", "Larvik"),
                new Profile("3", "Dani", "Tønsberg"),
                new Profile("4", "Erik", "Larvik"),
                new Profile("5", "Viktor", "Larvik"),
                new Profile("6", "Morten", "Kodal")              
            };
        
            while (true)
            {
               
                PrintMenu();
                var userInput = Console.ReadLine();
                HandleMenuOptions(userInput);               
            }           
        }

        public void PrintMenu()
        {
            
            Console.WriteLine("\nWelcome to Get Network:)");
            Console.WriteLine("1. Add Friend");
            Console.WriteLine("2. Remove Friend");
            Console.WriteLine("3. Print all friends");
            Console.WriteLine("4. Show friendInfo");

        }

        public void ShowUsers()
        {
            
            foreach (var user in ListOfUsers)
                Console.WriteLine($"{user.Name} {user.Id}" );
        }


        public void HandleMenuOptions(string menuOption)
        {
            if(menuOption == "1") 
            {
                Console.Clear();
                Console.WriteLine("MenuOption 1. Add Friend: ");
                Console.WriteLine("**************************");
                ShowUsers();
                Console.WriteLine("Chosse the ID of the user you want to add:  ");
                var chosenUserId = Console.ReadLine();
                var userProfile = GetUserProfile(chosenUserId);
                loggedInProfile.AddFriend(userProfile);
            }


            if (menuOption == "2")
            {
                Console.Clear();
                Console.WriteLine("MenuOption 2. Remove Friend: ");
                Console.WriteLine("****************************");
                loggedInProfile.ShowFriends();
                Console.WriteLine("Choose which friend to remove");
                var friendId = Console.ReadLine();
                var friendProfile = GetUserProfile(friendId);
                loggedInProfile.RemoveFriend(friendProfile);
            }


            if (menuOption == "3")
            {
                Console.Clear();
                Console.WriteLine("MenuOption 3. Print All Friends: ");
                Console.WriteLine("********************************");
                loggedInProfile.ShowFriends();
            }

            if (menuOption == "4")
            {
                Console.Clear();
                Console.WriteLine("MenuOption 4. Print Friend profile info: ");
                Console.WriteLine("*****************************************");
                loggedInProfile.ShowFriends();
                Console.WriteLine("Choose friend ID for info");
                var friendId = Console.ReadLine();
                var profile = GetUserProfile(friendId);
                profile.PrintProfileInfo();
            }
        }

        public Profile GetUserProfile(string id)
        {
            return ListOfUsers.FirstOrDefault(user => user.Id == id);
        }

      

    }
}
