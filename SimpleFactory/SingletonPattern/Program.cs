namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserSingleton user=UserSingleton.Instance;
            user.Name = "Boichev";
            user.Password = "12345";
            user.ChangePassword("Pederas");
            Console.WriteLine($"{user.Name} - {user.Password}");
        }
    }
}