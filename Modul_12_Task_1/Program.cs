using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Threading;
using static Program;

public class Program
{
    public delegate bool EligableToPremium(User UserToPremium);
    static void Main(string[] args)
    {
        User us1 = new User()
        {
            Login = "Frodo",
            Name = "Фёдор",
            IsPremium = true,
        };
        User us2 = new User()
        {
            Login = "Sem",
            Name = "Семён",
            IsPremium = true,
        };
        User us3 = new User()
        {
            Login = "Meriadoc",
            Name = "Анатолий",
            IsPremium = false,
        };
        User us4 = new User()
        {
            Login = "Peregrine",
            Name = "Пётр",
            IsPremium = false,
        };
        List<User> listUsers = new List<User>();
        listUsers.Add(us1);
        listUsers.Add(us2);
        listUsers.Add(us3);
        listUsers.Add(us4);


        EligableToPremium eligableToPremium = Premium;
        User.HasPremium(listUsers, eligableToPremium);
        Console.ReadKey();

    }
    public static bool Premium(User user)
    {
        if (user.IsPremium == true)

        {
            Console.WriteLine("\nЗдравствуйте, {0}. \nБлагодарим за Premium подписку", user.Name);
            return true;
        }

        else
        {
            Console.WriteLine("\nЗдравствуйте, {0}. \nPremium отсутствует", user.Name);

            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
            return false;
        }
    }
}

public class User
{
    public string Login { get; set; }
    public string Name { get; set; }

    public bool IsPremium { get; set; }

    public static void HasPremium(List<User> listUsers, EligableToPremium IsUserEligable)
    {
        foreach (User user in listUsers)
        {
            if (IsUserEligable(user))
            {
             
            }
        }
    }
}