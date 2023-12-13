using System;

namespace ConsoleApp45practic
{
    class Program
    {
        static void Main(string[] args)
        {

            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;


            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();

            User.LoginLength = User.Login.Length;
            Console.WriteLine("Длина логина {0}", User.LoginLength);

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



        }
    }
}
