namespace FakeBackend
{
    public class UserManager
    {
        private readonly object _options;

        public UserManager(object options)
        {
            _options = options;
        }

        public User GetUser(string username)
        {
            switch (username.Trim().ToLower())
            {
                case "jkally":
                    return new User
                    {
                        Username = username,
                        Name = "John Kally",
                        Position = "Manager"
                    };
                case "acooper":
                    return new User
                    {
                        Username = username,
                        Name = "Alicia Cooper",
                        Position = "Lead"
                    };
            }

            return null;
        }
    }
}
