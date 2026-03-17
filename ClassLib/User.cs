

namespace ClassLib
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(int id, int roleId, string name, string login, string password)
        {
            Id = id;
            RoleId = roleId;
            Name = name;
            Login = login;
            Password = password;
        }
    }
}