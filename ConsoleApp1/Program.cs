using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин : ");
            string login = Console.ReadLine();

            string path = "players.txt";

            string[] str = null;
            string[] str2;
            int id = 0;
            bool newPl = false;
            if (File.Exists(path))
            {
                str = File.ReadAllLines(path);
            }
            //else
            //{
            //    using (StreamWriter sw = new StreamWriter(path, false))
            //    {
            //        sw.WriteLine(login + ":" + 0);
            //    }
            //}

            User[] users = new User[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                users[i] = new User();
                str2 = str[i].Split(':');

                users[i].Login = str2[0];
                users[i].Money = Convert.ToInt32(str2[1]);
            }



            //Console.WriteLine($"Ты тамада. Сколько дашь попыток?");

            var consoleHelper = new ConsoleHelper();
            var game = new Game(consoleHelper);

            var gameRule = new GameRule()
            {
                MaxAttempts = 3,
                Number = 42
            };




            var user = new User();

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Login == login)
                {
                    user = users[i];
                    id = i;
                    newPl = false;
                    break;
                }
                else
                {
                    if (i + 1 == users.Length)
                    {
                        user = new User(login);
                        newPl = true;
                        break;
                    }
                    continue;
                }
            }
            //
            game.StartGame(gameRule, user);

            Console.WriteLine($"User score: {user.Money}");

            if (newPl)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(user.Login + ":" + user.Money);
                }
            }
            else
            {
                str[id] = user.Login + ":" + user.Money;

                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        sw.WriteLine(str[i]);
                    }
                }
                
            }

            Console.ReadKey();            
        }
    }
}
