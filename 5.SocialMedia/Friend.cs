using System;
using System.Collections.Generic;

namespace SocialMediaExample
{
    class SocialMedia
    {
        public Dictionary<string, List<string>> Friends { get; } = new Dictionary<string, List<string>>();

        public void AddFriend(string username, string friendName)
        {
            if (!Friends.ContainsKey(username))
                Friends[username] = new List<string>();

            Friends[username].Add(friendName);
        }

        public void RemoveFriend(string username, string friendName)
        {
            if (Friends.ContainsKey(username))
                Friends[username].Remove(friendName);
        }

        public List<string> GetAllFriendsByUsername(string username)
        {
            if (Friends.ContainsKey(username))
                return Friends[username];
            else
                return new List<string>(); // İstifadəçi tapılmadı
        }
    }
}