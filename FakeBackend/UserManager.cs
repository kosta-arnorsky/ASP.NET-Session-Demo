using System;

namespace FakeBackend
{
    public class UserManager
    {
        public UserManager(object options)
        {
        }

        public Profile GetProfile(string username)
        {
            if (Char.ToLowerInvariant(username[0]) < 'k')
            {
                return new Profile
                {
                    Username = username,
                    Name = "John Kally",
                    Position = "Manager"
                };
            }
            else
            {
                return new Profile
                {
                    Username = username,
                    Name = "Alicia Cooper",
                    Position = "Lead"
                };
            }
        }
    }
}
