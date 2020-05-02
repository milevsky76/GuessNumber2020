namespace ConsoleApp1
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public int Money { get; set; }

        public User() { }

        public User(string login)
        {
            Login = login;
            Money = 0;
        }
    }
}