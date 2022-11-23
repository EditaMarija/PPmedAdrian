using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedAdrian
{
    class Profile
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Address { get; set; }
        public List<Profile> Friends { get; set; }

        public Profile(string id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
            Friends = new List<Profile>();
        }

        public void AddFriend(Profile friendToAdd)
        {
            Friends.Add(friendToAdd);
        }
        public void RemoveFriend(Profile friendToRemove)
        {
            Friends.Remove(friendToRemove);
        }

        public void ShowFriends()
        {
            foreach (var friend in Friends)
            {
                Console.WriteLine(friend.Name + " " + friend.Id);
            }
        }
        public void PrintProfileInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Address: {Address}");
            ShowFriends();
        }


    }
}
