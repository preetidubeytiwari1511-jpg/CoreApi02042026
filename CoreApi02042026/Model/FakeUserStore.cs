namespace CoreApi02042026.Model
{
    public static class FakeUserStore
    {
        private static readonly List<AppUser> _users = new()
    {
        new AppUser { Username = "admin", Password = "admin123", Role = "Admin" },
        new AppUser { Username = "john",  Password = "john123",  Role = "User"  },
        new AppUser { Username = "jane",  Password = "jane123",  Role = "User"  }
    };

        // ✅ Returns AppUser class — no tuple, no .Value needed
        public static AppUser? Validate(string username, string password)
        {
            return _users.FirstOrDefault(u =>
                u.Username == username &&
                u.Password == password);
        }
    }
}
