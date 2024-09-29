



class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();
            Console.Write("Введите логин: ");
            user.Login = Console.ReadLine();
            Console.Write("Введите имя: ");
            user.Name = Console.ReadLine();
            Console.Write("Введите есть ли у вас наша подписка (да/нет): ");
            user.IsPremium = Console.ReadLine();

            if (user.IsPremium == "Нет")
            {
                ShowAds();
                Console.ReadKey();

            }    
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public string IsPremium { get; set; }
        }
    }

}