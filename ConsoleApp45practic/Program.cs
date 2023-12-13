using System;

namespace ConsoleApp45practic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.5.1
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User1;
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User2;

            // User
            // 4.5.2
            Console.WriteLine("User"); Console.WriteLine("");
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();

            // 4.5.3
            User.LoginLength = User.Login.Length;
            Console.WriteLine("Длина логина {0}", User.LoginLength);

            // 4.5.4
            string yesno = "";
            while (true)
            {
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                yesno = Console.ReadLine();
                if (yesno == "Да")
                {
                    User.HasPet = true;
                    break;
                }
                else if (yesno == "Нет")
                {
                    User.HasPet = false;
                    break;
                }
            }
            string Answer = User.HasPet ? "Да" : "Нет";
            Console.WriteLine("Вы ответили {0}", Answer);

            Console.WriteLine("Введите возраст пользователя");
            User.Age = double.Parse(Console.ReadLine());

            // 4.5.5
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            string scolor = "Введите три любимых цвета пользователя из - ";
            foreach (var color in colors)
                scolor = scolor + " " + color.ToString();
            Console.WriteLine(scolor);
            User.favcolors = new string[3];
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                Console.WriteLine("Введите цыет номер {0}", i);
                User.favcolors[i] = Console.ReadLine();
            }

            // User1
            // 4.5.2
            Console.WriteLine(""); Console.WriteLine("User1"); Console.WriteLine("");
            Console.WriteLine("Введите имя");
            User1.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User1.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User1.Login = Console.ReadLine();

            // 4.5.3
            User1.LoginLength = User1.Login.Length;
            Console.WriteLine("Длина логина {0}", User1.LoginLength);

            // 4.5.4
            string yesno1 = "";
            while (true)
            {
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                yesno1 = Console.ReadLine();
                if (yesno1 == "Да")
                {
                    User1.HasPet = true;
                    break;
                }
                else if (yesno1 == "Нет")
                {
                    User1.HasPet = false;
                    break;
                }
            }
            string Answer1 = User1.HasPet ? "Да" : "Нет";
            Console.WriteLine("Вы ответили {0}", Answer1);

            Console.WriteLine("Введите возраст пользователя");
            User1.Age = double.Parse(Console.ReadLine());

            // 4.5.5
            ConsoleColor[] colors1 = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            string scolor1 = "Введите три любимых цвета пользователя из - ";
            foreach (var color1 in colors1)
                scolor1 = scolor1 + " " + color1.ToString();
            Console.WriteLine(scolor1);
            User1.favcolors = new string[3];
            for (int i = 0; i < User1.favcolors.Length; i++)
            {
                Console.WriteLine("Введите цыет номер {0}", i);
                User1.favcolors[i] = Console.ReadLine();
            }

            // User2
            // 4.5.2
            Console.WriteLine(""); Console.WriteLine("User2"); Console.WriteLine("");
            Console.WriteLine("Введите имя");
            User2.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User2.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User2.Login = Console.ReadLine();

            // 4.5.3
            User2.LoginLength = User2.Login.Length;
            Console.WriteLine("Длина логина {0}", User.LoginLength);

            // 4.5.4
            string yesno2 = "";
            while (true)
            {
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                yesno2 = Console.ReadLine();
                if (yesno2 == "Да")
                {
                    User2.HasPet = true;
                    break;
                }
                else if (yesno2== "Нет")
                {
                    User2.HasPet = false;
                    break;
                }
            }
            string Answer2 = User2.HasPet ? "Да" : "Нет";
            Console.WriteLine("Вы ответили {0}", Answer2);

            Console.WriteLine("Введите возраст пользователя");
            User2.Age = double.Parse(Console.ReadLine());

            // 4.5.5
            ConsoleColor[] colors2 = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            string scolor2 = "Введите три любимых цвета пользователя из - ";
            foreach (var color2 in colors2)
                scolor2 = scolor2 + " " + color2.ToString();
            Console.WriteLine(scolor2);
            User2.favcolors = new string[3];
            for (int i = 0; i < User2.favcolors.Length; i++)
            {
                Console.WriteLine("Введите цыет номер {0}", i);
                User2.favcolors[i] = Console.ReadLine();
            }



        }
    }
}
