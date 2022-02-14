using System.Collections.Generic;

namespace ToDo_App
{
    public class UserList
    {
        public List<User> users=new List<User>();

        public UserList()
        {
            users.Add(new User(1, "Tunahan Karaçoban"));
            users.Add(new User(2, "Tarık Demirci"));
            users.Add(new User(3, "Alican Pamuk"));
            users.Add(new User(4, "Nadir Korkut"));

        }
    }
}