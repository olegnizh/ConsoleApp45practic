using System;

namespace ConsoleApp45practic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.5.1
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

 
                // 4.5.2
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
                                       


        }
    }
}
