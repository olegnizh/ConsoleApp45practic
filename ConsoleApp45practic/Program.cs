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


        }
    }
}
