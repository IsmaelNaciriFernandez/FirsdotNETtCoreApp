using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreApp.Learning
{
    internal class Debugging_test
    {
        


        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list is null)
            {
                throw new ArgumentNullException("list", "The list is null!");
            }
            else if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater than the list length");
            } 
            else if (list.Count == 0)
            {
                throw new ArgumentOutOfRangeException("list", "List cannot be empty.");
            }

            var buffer = new List<string>(list);
            var partyFriends = new List<string>();

            while (partyFriends.Count < count) 
            {
                var currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend); //STC
            }

            return partyFriends;
        }

        private static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (int i = 1; i < list.Count; i++) { 
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
