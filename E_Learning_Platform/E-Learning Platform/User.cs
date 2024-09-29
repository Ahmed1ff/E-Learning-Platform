namespace E_Learning_Platform
{
    public abstract class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual void Login()
        {
            Console.WriteLine($"{Name} logged in.");
        }

        public virtual void Register()
        {
            Console.WriteLine($"{Name} registered.");
        }
    }

}
