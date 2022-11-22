using System;

namespace практическая10
{
    class Program
    {
        static void Main(string[] args)
        {
            string fio = "Работу выполнила студентка группы ИСиП-2-21 Пушкарная А.В.";
            string def = "---------------------------------------------------------------------";

            Console.WriteLine(fio);
            Console.WriteLine(def);
            Console.WriteLine("Практическая работа №10.");
            Console.WriteLine(def);
            new Generator().PasswordCreate();
        }
    }
}
